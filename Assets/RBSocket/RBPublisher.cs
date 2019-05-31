using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using RBS;
using RBS.Messages;

public abstract class RBPublisher
{
    public abstract string Id { get; set; }
    public abstract string Topic { get; set; }
    public abstract string AdvertiseMsg { get; set; }
    public abstract string TypeName { get; }
}

public class RBPublisher<T> : RBPublisher where T : ExtendMessage, new()
{
    private string id;
    private string topic;
    private string advertiseMsg;
    private string typeName = new MessagesInstance<T>().TypeName;
    private PublishMessage<T> publishMessage;
    private MessagesInstance<T> messagesInstance;

    public override string Id
    {
        get { return id; }
        set { id = value; }
    }
    public override string Topic
    {
        get { return topic; }
        set { topic = value; }
    }
    public override string AdvertiseMsg
    {
        get { return advertiseMsg; }
        set { advertiseMsg = value; }
    }
    public override string TypeName
    {
        get { return typeName; }
    }

    public RBPublisher(string t, string id = "")
    {
        Topic = t; Id = id;
        publishMessage = new PublishMessage<T>();
        publishMessage.topic = topic;
        ReadyAdvertise();
        ReadyUnAdvertise();
    }

    private void ReadyAdvertise()
    {
        Advertise advertise = new Advertise();
        advertise.topic = Topic;
        advertise.type = TypeName;
        AdvertiseMsg = JsonUtility.ToJson(advertise);
        RBSocket.Instance.OperationSend(AdvertiseMsg);
    }

    private void ReadyUnAdvertise()
    {
        UnAdvertise unadvertise = new UnAdvertise();
        unadvertise.topic = Topic;
        RBSocket.Instance.AddUnAdvertise(unadvertise);
    }

    public void Publish(T msg)
    {
        if (RBSocket.Instance.IsAdvertise(AdvertiseMsg))
        {
            if (RBSocket.Instance.IsConnected)
            {
                if (msg.Type() == TypeName)
                {
                    publishMessage.msg = msg;
                    RBSocket.Instance.MessageSend(JsonUtility.ToJson(publishMessage));
                }
            }
            else
            {
                Debug.LogWarning("The connection with ROS has not been completed...(Publish)");
            }
        }
        else
        {
            if (!RBSocket.Instance.IsConnected)
            {
                Debug.LogWarning("Advertise has not been added...(Publish)");
            }
        }
    }
}