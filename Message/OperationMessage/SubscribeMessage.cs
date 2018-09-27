﻿namespace ROSBridgeSharp.Messages
{
    [System.Serializable]
    public class SubscribeMessage<T> : Message where T : Message
    {
        public string op;
        public string topic;
        public T msg;
    }
}
