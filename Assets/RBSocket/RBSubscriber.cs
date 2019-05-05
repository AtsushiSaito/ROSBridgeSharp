using System.Collections.Generic;
using UnityEngine;
using System;
using WebSocketSharp;
using RBS;
using RBS.Messages;

// サブスクライバを管理するマネージャー
public abstract class SubscribeManager
{
    public string topic; // 内部で保持するトピック名
    public SubscribeOperationMessage subscribe; // オペレーションメッセージ
    public abstract void HandlerFunction(string m);
}

public class SubscribeManager<T> : SubscribeManager where T : ExtendMessage, new()
{
    internal Action<T> Handler; // コールバック関数のハンドラーのデリゲートを生成
    internal T mesType;
    public SubscribeManager(string t, Action<T> h) // コンストラクタ
    {
        // オペレーションを設定
        mesType = new T();
        subscribe = new SubscribeOperationMessage(); // オペレーションメッセージを作成
        subscribe.topic = t; //トピック名を設定
        subscribe.type = mesType.Type();
        string data = JsonUtility.ToJson(subscribe); // JSONに変換
        RBSocket.Instance.OperationSend(data); // 送信

        topic = t; // トピック名を登録
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

public class RBSubscriber<T> where T : ExtendMessage, new()
{
    internal string topic;
    public RBSubscriber(string t, Action<T> h)
    {
        topic = t;
        SubscribeManager<T> manager = new SubscribeManager<T>(t, h);
        RBSocket.Instance.SetSubscriber(manager);
    }
}