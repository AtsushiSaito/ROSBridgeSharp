using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System;
using WebSocketSharp;
using RBS;
using RBS.Messages;

// サブスクライバを管理するマネージャー
public abstract class ServiceClientManager
{
    public string service_name; // 内部で保持するトピック名
    public abstract void ResponseFunction(string m); // レスポンスが来たら呼び出す
}

public class ServiceClientManager<Tin, Tout> : ServiceClientManager where Tin : ExtendMessage where Tout : ExtendMessage, new()
{
    internal string data;
    internal bool isResponseReceived;
    internal ServiceResponseMessage<Tout> receive_data;
    internal CallServiceMessage<Tin> request_data;
    public ServiceClientManager(string s) // コンストラクタ
    {
        // オペレーションを設定
        service_name = s;
        request_data = new CallServiceMessage<Tin>();
    }
    internal ServiceResponseMessage<Tout> ParseMessage(string m) // データが降ってきたらJsonをパース
    {
        return JsonUtility.FromJson<ServiceResponseMessage<Tout>>(m);
    }

    public override void ResponseFunction(string m)
    {
        receive_data = ParseMessage(m);
        isResponseReceived = true;
    }

    public void SendData(ref Tin in_data)
    {
        request_data.service = service_name; //サービス名を設定
        // List<Tin> lists = new List<Tin>();
        // lists.Add(in_data);
        request_data.args = in_data;
        data = JsonUtility.ToJson(request_data); // JSONに変換
        Debug.Log(data);

        RBSocket.Instance.MessageSend(data); // 送信
    }
}

public class RBServiceClient<Tin, Tout> where Tin : ExtendMessage where Tout : ExtendMessage, new()
{
    internal string service;
    ServiceClientManager<Tin, Tout> manager;
    public RBServiceClient(string s)
    {
        service = s;
        manager = new ServiceClientManager<Tin, Tout>(s);
        RBSocket.Instance.SetServiceClient(manager);
    }

    private IEnumerator Waiting()
    {
        yield return new WaitForSeconds(0.02f); // num秒待機
    }

    public void Call(ref Tin in_data, ref Tout out_data)
    {
        manager.isResponseReceived = false;
        manager.SendData(ref in_data);
        while (!manager.isResponseReceived)
        {
            Waiting();
        }
        out_data = manager.receive_data.values;
    }
}