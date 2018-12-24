using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using ROSBridgeSharp;
using ROSBridgeSharp.Messages;

public class RBPublisher<T> where T : ExtendMessage, new()
{
    internal string Topic;
    internal PublishMessage<T> data;
    internal T mesType;
    public RBPublisher(string t)
    {
        Topic = t;
        mesType = new T();
        data = new PublishMessage<T>();
        data.topic = t;
        Advertise advertise = new Advertise();
        advertise.topic = t;
        advertise.type = mesType.Type();

        RBSocket.Instance.QueueSend(JsonUtility.ToJson(advertise));

        UnAdvertise unadvertise = new UnAdvertise();
        unadvertise.topic = t;
        RBSocket.Instance.AddUnAdvertise(unadvertise);
    }
    public void publish(T d)
    {
        if (RBSocket.Instance.IsAdvertise(Topic))
        {
            if (RBSocket.Instance.IsConnected)
            {
                data.msg = d;
                RBSocket.Instance.DirectSend(JsonUtility.ToJson(data));
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