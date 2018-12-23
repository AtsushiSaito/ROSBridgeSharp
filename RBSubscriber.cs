using System.Collections.Generic;
using UnityEngine;
using System;
using WebSocketSharp;
using ROSBridgeSharp;
using ROSBridgeSharp.Messages;

// サブスクライバを管理するマネージャー
public abstract class SubscribeManager
{
    public string Topic; // 内部で保持するトピック名
    public OperationMessage subscribe; // オペレーションメッセージ
    public abstract void HandlerFunction(string m);
}

public class SubscribeManager<T> : SubscribeManager where T : Message
{
    internal Action<T> Handler; // コールバック関数のハンドラーのデリゲートを生成
    public SubscribeManager(string t, Action<T> h) // コンストラクタ
    {
        // オペレーションを設定
        subscribe = new OperationMessage(); // オペレーションメッセージを作成
        subscribe.op = "subscribe"; // サブスクライブ申請
        subscribe.topic = t; //トピック名を設定

        string data = JsonUtility.ToJson(subscribe); // JSONに変換
        RBSocket.Instance.Send(data); // 送信

        Topic = t; // トピック名を登録
        Handler = h; // ハンドラを登録
    }
    internal SubscribeMessage<T> ParseMessage(string m) // データが降ってきたらJsonをパース
    {
        return JsonUtility.FromJson<SubscribeMessage<T>>(m);
    }

    public override void HandlerFunction(string m)
    {
        SubscribeMessage<T> d = ParseMessage(m);
        Handler(d.msg);
    }
}

public class RBSubscriber<T> where T : Message
{
    internal string Topic;
    public RBSubscriber(string t, Action<T> h)
    {
        Topic = t;
        SubscribeManager<T> manager = new SubscribeManager<T>(t, h);
        RBSocket.Instance.SetSubscriber(manager);
    }
}