using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System;
using WebSocketSharp;
using RBS;
using RBS.Messages;

public delegate void SubscribeDelegate<T>(T messageObject) where T : ExtendMessage;

public class RBSubscriber<T> where T : ExtendMessage, new()
{
    private string topic;
    public string Topic
    {
        get { return topic; }
        set { topic = value; }
    }

    public RBSubscriber(string t, SubscribeDelegate<T> h)
    {
        Topic = t;
        SubscribeManager<T> manager = new SubscribeManager<T>(t, h, RBSocket.Instance.IDCount.ToString());
        RBSocket.Instance.AddSubscribeManager(manager);
    }
}

public abstract class SubscribeManager
{
    public abstract string ID { get; set; }
    public abstract string Topic { get; set; }
    public abstract string TypeName { get; }
    public abstract bool IsRunning { get; }
    public abstract void HandlerFunction(string messageJson);
    public abstract string GetViewJson();
}

public class SubscribeManager<T> : SubscribeManager where T : ExtendMessage, new()
{
    private string id;
    private string topic;
    private string advertiseMsg;
    private bool isRunning;
    private string typeName = new MessagesInstance<T>().TypeName;
    private SubscribeDelegate<T> handler;
    private T messageData;

    public override string ID
    {
        get { return id; }
        set { id = value; }
    }

    public override string Topic
    {
        get { return topic; }
        set { topic = value; }
    }

    public override string TypeName
    {
        get { return typeName; }
    }

    public override bool IsRunning
    {
        get { return isRunning; }
    }

    public SubscribeDelegate<T> Handler
    {
        get { return handler; }
        set { handler = value; }
    }

    private void SubscribeOperationMessageSend()
    {
        SubscribeOperationMessage subscribeOperationMessage = new SubscribeOperationMessage();
        subscribeOperationMessage.topic = Topic;
        subscribeOperationMessage.type = TypeName;
        RBSocket.Instance.SendOperationMessage(JsonUtility.ToJson(subscribeOperationMessage));
    }

    public SubscribeManager(string t, SubscribeDelegate<T> h, string id = "")
    {
        Topic = t; Handler = h; ID = id;
        SubscribeOperationMessageSend();
    }

    private void HandlerFunctionTask(string messageJson)
    {
        isRunning = true;
        messageData = JsonUtility.FromJson<SubscribeMessage<T>>(messageJson).msg;
        Handler(messageData);
        isRunning = false;
    }

    public override void HandlerFunction(string messageJson)
    {
        Task.Run(() =>
        {
            HandlerFunctionTask(messageJson);
        });
    }

    public override string GetViewJson()
    {
        if (messageData != null)
            return messageData.ConvertString();
        return "";
    }
}