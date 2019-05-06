using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System;
using WebSocketSharp;
using RBS;
using RBS.Messages;


public class ServiceClientAsyncManager<Tin, Tout> : ServiceClientManager where Tin : ExtendMessage where Tout : ExtendMessage, new()
{
    internal string data;
    internal ServiceResponseMessage<Tout> receive_data;
    internal CallServiceMessage<Tin> request_data;
    internal Action<Tout> Handler; // コールバック関数のハンドラーのデリゲートを生成
    public ServiceClientAsyncManager(string s, Action<Tout> h) // コンストラクタ
    {
        // オペレーションを設定
        service_name = s;
        request_data = new CallServiceMessage<Tin>();
        Handler = h;
    }
    internal ServiceResponseMessage<Tout> ParseMessage(string m) // データが降ってきたらJsonをパース
    {
        return JsonUtility.FromJson<ServiceResponseMessage<Tout>>(m);
    }

    public override void ResponseFunction(string m)
    {
        receive_data = ParseMessage(m);
        Handler(receive_data.values);
    }

    public void SendData(ref Tin in_data)
    {
        request_data.service = service_name; //サービス名を設定
        request_data.args = in_data;
        data = JsonUtility.ToJson(request_data); // JSONに変換
        RBSocket.Instance.MessageSend(data); // 送信
    }
}

public class RBServiceAsyncClient<Tin, Tout> where Tin : ExtendMessage where Tout : ExtendMessage, new()
{
    internal string service;
    ServiceClientAsyncManager<Tin, Tout> manager;
    public RBServiceAsyncClient(string s, Action<Tout> h)
    {
        service = s;
        manager = new ServiceClientAsyncManager<Tin, Tout>(s, h);
        RBSocket.Instance.SetServiceClient(manager);
    }

    public void Call(ref Tin in_data, ref Tout out_data)
    {
        manager.SendData(ref in_data);
    }
}