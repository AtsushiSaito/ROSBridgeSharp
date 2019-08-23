using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using WebSocketSharp;
using RBS.Messages;


namespace RBS
{
    public class RBSocket : MonoBehaviour
    {
        public string IPAddress;
        public string Port;
        public bool AutoConnect = false;
        public float ConnectWaitTime = 2.5f;

        private WebSocket ws;
        private static RBSocket instance;

        private readonly Queue<string> waitOperationMessagesQueue = new Queue<string>();
        private readonly Queue<string> sentOperationMessagesQueue = new Queue<string>();

        private List<PublishUnAdvertiseMessage> publishUnAdvertiseMessages = new List<PublishUnAdvertiseMessage>();
        private List<ServiceUnAdvertiseMessage> serviceUnAdvertiseMessages = new List<ServiceUnAdvertiseMessage>();

        private List<SubscribeManager> subscribeManagers = new List<SubscribeManager>();
        private List<ServiceClientManager> serviceClientManagers = new List<ServiceClientManager>();
        private List<ServiceServerManager> serviceServerManagers = new List<ServiceServerManager>();

        private bool isConnected = false;
        private bool isUpdateRunning = false;
        private int idCount = 0;

        private void Start()
        {
            if (AutoConnect)
            {
                Invoke("Connect", ConnectWaitTime);
            }
        }

        private void Update()
        {
            isUpdateRunning = true;
            if (isConnected && waitOperationMessagesQueue.Count > 0)
            {
                string message = waitOperationMessagesQueue.Dequeue();
                ws.Send(message);
                sentOperationMessagesQueue.Enqueue(message);
            }
        }

        void OnDestroy()
        {
            if (isUpdateRunning)
            {
                Disconnect();
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
                    OperationMessage data = JsonUtility.FromJson<OperationMessage>(e.Data);
                    if (data.op == "publish")
                    {
                        SubscribeMessage msg = JsonUtility.FromJson<SubscribeMessage>(e.Data);
                        foreach (SubscribeManager sm in subscribeManagers)
                        {
                            if (msg.topic == sm.Topic)
                            {
                                if (!sm.IsRunning)
                                {
                                    sm.HandlerFunction(e.Data);
                                }
                            }
                        }
                    }

                    else if (data.op == "service_response")
                    {
                        ServiceResponseMessage msg = JsonUtility.FromJson<ServiceResponseMessage>(e.Data);
                        foreach (ServiceClientManager sc in serviceClientManagers)
                        {
                            if (msg.service == sc.service_name)
                            {
                                sc.ResponseFunction(e.Data);
                            }
                        }
                    }

                    else if (data.op == "call_service")
                    {
                        CallServiceMessage msg = JsonUtility.FromJson<CallServiceMessage>(e.Data);
                        foreach (var ss in serviceServerManagers)
                        {
                            if (msg.service == ss.service)
                            {
                                ss.HandlerFunction(e.Data);
                            }
                        }
                    }
                };

                ws.OnError += (sender, e) =>
                {
                    Debug.Log("WebSocket Error Message: " + e.Message);
                };

                ws.OnClose += (sender, e) =>
                {
                    Debug.Log("WebSocket Closed.");
                    isConnected = false;
                };

                if (IsConnectable())
                {
                    ws.Connect();
                }
            }
        }

        public void Disconnect()
        {
            if (isConnected)
            {
                waitOperationMessagesQueue.Clear();
                AllUnSubscribe();
                AllUnAdvertise();
                SetReSendOperationMessages();

                ws.Close();
                isConnected = false;
            }
        }

        public int IDCount
        {
            get { return idCount; }
        }

        public bool IsConnected
        {
            get
            {
                return isConnected;
            }
        }

        public static RBSocket Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = FindObjectOfType<RBSocket>();
                    if (instance != null)
                    {
                        Debug.Log("RBScoket instance ready.");
                    }
                    else
                    {
                        Debug.LogError("RBSocket instance not ready.");
                    }
                }
                return instance;
            }
        }

        public bool IsConnectable()
        {
            Ping wsPing = new Ping(IPAddress);
            while (!wsPing.isDone) { }
            if (wsPing.time >= 0)
            {
                Debug.Log(IPAddress + " is connectable");
                return true;
            }
            else
            {
                Debug.LogWarning(IPAddress + " is not connectable");
                return false;
            }
        }

        public bool IsAdvertise(string op)
        {
            foreach (string som in sentOperationMessagesQueue)
            {
                if (som == op)
                {
                    return true;
                }
            }
            return false;
        }

        public void MessageSend(string m)
        {
            ws.Send(m);
        }

        public void SendOperationMessage(string m)
        {
            waitOperationMessagesQueue.Enqueue(m);
            idCount++;
        }

        public void AddSubscribeManager(SubscribeManager sm)
        {
            subscribeManagers.Add(sm);
        }

        public void AddServiceServer(ServiceServerManager ssm)
        {
            serviceServerManagers.Add(ssm);
        }

        public void AddServiceClient(ServiceClientManager scm)
        {
            serviceClientManagers.Add(scm);
        }

        public void AddUnAdvertise(PublishUnAdvertiseMessage a)
        {
            publishUnAdvertiseMessages.Add(a);
        }

        public void AddServiceUnAdvertise(ServiceUnAdvertiseMessage a)
        {
            serviceUnAdvertiseMessages.Add(a);
        }

        private void SetReSendOperationMessages()
        {
            if (sentOperationMessagesQueue.Count > 0)
            {
                string data = sentOperationMessagesQueue.Dequeue();
                waitOperationMessagesQueue.Enqueue(data);
                if (sentOperationMessagesQueue.Count > 0)
                {
                    SetReSendOperationMessages();
                }
            }
        }

        public void SendUnAdvertiseMessage(PublishUnAdvertiseMessage ua)
        {
            ws.Send(JsonUtility.ToJson(ua));
        }

        public void SendUnSubscribeOperationMessage(string t)
        {
            UnSubscribeOperationMessage unsubscribe = new UnSubscribeOperationMessage();
            unsubscribe.topic = t;
            ws.Send(JsonUtility.ToJson(unsubscribe));
        }

        private void AllUnSubscribe()
        {
            foreach (SubscribeManager s in subscribeManagers)
            {
                SendUnSubscribeOperationMessage(s.Topic);
            }
        }

        private void AllUnAdvertise()
        {
            foreach (var ua in publishUnAdvertiseMessages)
            {
                ws.Send(JsonUtility.ToJson(ua));
            }

            foreach (var ua in serviceUnAdvertiseMessages)
            {
                ws.Send(JsonUtility.ToJson(ua));
            }
        }

        public ref List<SubscribeManager> GetSubscribeManagers()
        {
            return ref subscribeManagers;
        }
    }
}