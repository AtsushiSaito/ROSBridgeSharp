using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using WebSocketSharp;
using ROSBridgeSharp.Messages;

namespace ROSBridgeSharp
{
    public class RBSocket : MonoBehaviour
    {
        internal string IPAddress = "192.168.3.28"; // IPアドレス
        internal string Port = "9000"; //ポート番号

        private WebSocket ws; // WebSocketSharp
        private static RBSocket instance; // インスタンスの実体
        private readonly Queue<string> MessageQueue = new Queue<string>();
        private List<SubscribeManager> Subscribers = new List<SubscribeManager>();
        private bool isConnected = false;

        // インスタンスのプロパティー
        public static RBSocket Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = FindObjectOfType<RBSocket>();
                    if (instance != null)
                    {
                        Debug.Log("RBScoket Instance OK.");
                    }
                    else
                    {
                        Debug.LogError("RBSocket Instance Error.");
                    }
                }
                return instance;
            }
        }

        // 接続状態のプロパティー
        public bool IsConnected
        {
            get
            {
                return isConnected;
            }
        }

        public void Connect()
        {
            if (!isConnected)
            {
                ws = new WebSocket("ws://" + IPAddress + ":" + Port + "/");
                ws.OnOpen += (sender, e) =>
                {
                    Debug.Log("WebSocket Opened.");
                    isConnected = true;
                };

                ws.OnMessage += (sender, e) =>
                {
                    var msg = JsonUtility.FromJson<QueueSubscribeMessage>(e.Data);
                    foreach (var sm in Subscribers)
                    {
                        if (msg.topic == sm.Topic)
                        {
                            sm.HandlerFunction(e.Data);
                        }
                    }

                };

                ws.OnClose += (sender, e) =>
                {
                    Debug.Log("WebSocket Closed.");
                    isConnected = false;
                };
                ws.Connect();
            }
        }

        public void Disconnect()
        {
            if (isConnected)
            {
                AllUnSubscribe();
                ws.Close();
                isConnected = false;
            }
        }

        private void Update()
        {
        }

        public void SetSubscriber(SubscribeManager sm)
        {
            Subscribers.Add(sm);
        }

        public void Send(string m)
        {
            ws.Send(m);
        }

        public void UnSubscribe(string t)
        {
            OperationMessage unsubscribe = new OperationMessage();
            unsubscribe.op = "unsubscribe";
            unsubscribe.topic = t;

            string data = JsonUtility.ToJson(unsubscribe);
            Send(data);
        }

        private void AllUnSubscribe()
        {
            MessageQueue.Clear();
            foreach (var s in Subscribers)
            {
                UnSubscribe(s.Topic);
            }
            Subscribers.Clear();
        }

        private void OnDestroy()
        {
            AllUnSubscribe();
            Disconnect();
        }
    }
}