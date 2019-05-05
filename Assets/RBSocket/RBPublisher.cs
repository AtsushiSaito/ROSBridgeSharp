using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using RBS;
using RBS.Messages;

public class RBPublisher<T> where T : ExtendMessage, new()
{
    internal string Topic;
    internal PublishMessage<T> data;
    internal T mesType;
    internal string advertise_msg;
    public RBPublisher(string t)
    {
        Topic = t;
        mesType = new T();
        data = new PublishMessage<T>();
        data.topic = t;
        Advertise advertise = new Advertise();
        advertise.topic = t;
        advertise.type = mesType.Type();
        advertise_msg = JsonUtility.ToJson(advertise);

        RBSocket.Instance.OperationSend(advertise_msg);

        UnAdvertise unadvertise = new UnAdvertise();
        unadvertise.topic = t;
        RBSocket.Instance.AddUnAdvertise(unadvertise);
    }
    public void publish(T d)
    {
        if (RBSocket.Instance.IsAdvertise(advertise_msg))
        {
            if (RBSocket.Instance.IsConnected)
            {
                data.msg = d;
                RBSocket.Instance.MessageSend(JsonUtility.ToJson(data));
            }
            else
            {
                Debug.LogWarning("not Connected...(Publish)");
            }
        }
        else
        {
            if (!RBSocket.Instance.IsConnected)
            {
                Debug.LogWarning("no Add Advertise...(Publish)");
            }
        }
    }
}