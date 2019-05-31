using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using RBS;
using RBS.Messages;

// サブスクライバを管理するマネージャー
public abstract class ServiceServerManager
{
    public string service; // サービス名
    public ServiceAdvertiseMessage advertise; // オペレーションメッセージ
    public abstract void HandlerFunction(string m);
}


public class ServiceServerManager<Tin, Tout> : ServiceServerManager where Tin : ExtendMessage where Tout : ExtendMessage, new()
{
    internal Func<Tin, Tout> Handler; // コールバック関数のハンドラーのデリゲートを生成
    internal Tout MsgType;
    public ServiceServerManager(string s, Func<Tin, Tout> h) // コンストラクタ
    {
        // オペレーションを設定
        MsgType = new Tout();
        advertise = new ServiceAdvertiseMessage(); // オペレーションメッセージを作成
        advertise.service = s;
        advertise.type = MsgType.Type();
        string data = JsonUtility.ToJson(advertise); // JSONに変換
        RBSocket.Instance.SendOperationMessage(data); // 送信

        service = s;
        Handler = h;
    }

    public void SendData(ref Tout response, string id)
    {
        ServiceResponseMessage<Tout> response_data = new ServiceResponseMessage<Tout>();
        response_data.service = service; //サービス名を設定
        response_data.values = response;
        response_data.id = id;
        response_data.result = true;
        string data = JsonUtility.ToJson(response_data); // JSONに変換
        RBSocket.Instance.MessageSend(data); // 送信
    }

    // クライアントから送られてきたJSONデータをパース
    internal CallServiceMessage<Tin> ParseMessage(string m)
    {
        return JsonUtility.FromJson<CallServiceMessage<Tin>>(m);
    }

    public override void HandlerFunction(string m)
    {
        CallServiceMessage<Tin> d = ParseMessage(m);
        Tout data = Handler(d.args);
        SendData(ref data, d.id);
    }
}

public class RBServiceServer<Tin, Tout> where Tin : ExtendMessage where Tout : ExtendMessage, new()
{
    internal string service;
    public RBServiceServer(string s, Func<Tin, Tout> h)
    {
        service = s;
        ServiceServerManager<Tin, Tout> manager = new ServiceServerManager<Tin, Tout>(s, h);
        RBSocket.Instance.AddServiceServer(manager);

        ServiceUnAdvertiseMessage unadvertise = new ServiceUnAdvertiseMessage();
        unadvertise.service = service;
        RBSocket.Instance.AddServiceUnAdvertise(unadvertise);
    }
}