using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using ROSBridgeSharp.Messages;

namespace ROSBridgeSharp{

    // サブスクライブ時のハンドラ用デリゲート
    public delegate void SubscribeHandlerDelegate<T>(T m);

    // 連想配列用の抽象クラスを作成
    internal abstract class Subscriber{
        internal abstract void ReciveData(string m);
    }

    // 抽象クラスからジェネリッククラスを作成 : Tの取りうるクラスはMessage
    internal class Subscriber<T> : Subscriber where T : Message{
        // デリゲートからハンドル用関数の実体を作る。
        internal SubscribeHandlerDelegate<T> RecivedHandler;
        // トピック名
        internal string Topic;

        // コンストラクタでトピック名とハンドラを登録
        internal Subscriber(string t, SubscribeHandlerDelegate<T> h){
            RecivedHandler = h;
            Topic = t;
        }

        // WebSocketからデータを受信した際にJSONをパースしてハンドラを実行する関数
        internal override void ReciveData(string m)
        {
            SubscribeMessage<T> data = JsonUtility.FromJson<SubscribeMessage<T>>(m);
            RecivedHandler(data.msg);
        }
    }

    public class RBSocket
    {
        internal string IPAddress;
        internal string Port;
        internal bool isConnected = false;

        public WebSocket ws;

        public delegate void SubscribeDelegate(string message);
        private readonly Queue<string> MessageQueue = new Queue<string>();
        private readonly Queue<string> OperationQueue = new Queue<string>();
        internal Dictionary<string, Subscriber> Subscribers = new Dictionary<string, Subscriber>();

        public void ConnectionStart()
        {
            ws = new WebSocket("ws://" + IPAddress + ":" + Port + "/");

            ws.OnOpen += (sender, e) =>
            {
                Debug.Log("WebSocket Opened.");
            };

            ws.OnMessage += (sender, e) =>
            {
                MessageQueue.Enqueue(e.Data);
            };

            ws.OnClose += (sender, e) =>
            {
                Debug.Log("WebSocket Closed.");
            };

            ws.Connect();
            isConnected = true;
        }

        public void ConnectionClose()
        {
            MessageQueue.Clear();
            foreach (var s in Subscribers){
                RemoveSubscribe(s.Key);
            }
            Subscribers.Clear();
            ws.Close();
            isConnected = false;
        }

        public void Update()
        {
            if(OperationQueue.Count > 0 && isConnected)
            {
                string operation = OperationQueue.Dequeue();
                ws.Send(operation);
            }
            if(MessageQueue.Count > 0 && isConnected)
            {
                string message = MessageQueue.Dequeue();
                var data = JsonUtility.FromJson<OperationMessage>(message);
                foreach (var s in Subscribers){
                    if(data.topic == s.Key){
                        s.Value.ReciveData(message);
                    }
                }
            }
        }

        public void AddSubscribe<T>(string t, SubscribeHandlerDelegate<T> h) where T : Message
        {
            Subscribers.Add(t, new Subscriber<T>(t, h));
            OperationMessage message = new OperationMessage();
            message.op = "subscribe";
            message.topic = t;

            string data = JsonUtility.ToJson(message);
            OperationQueue.Enqueue(data);
        }

        public void RemoveSubscribe(string t)
        {
            OperationMessage message = new OperationMessage();
            message.op = "unsubscribe";
            message.topic = t;

            string data = JsonUtility.ToJson(message);
            ws.Send(data);
        }

        public Type Parse<Type>(string m){
            Type data = JsonUtility.FromJson<Type>(m);
            return data;
        }
    }
}