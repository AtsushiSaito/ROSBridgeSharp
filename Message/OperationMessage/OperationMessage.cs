﻿namespace ROSBridgeSharp.Messages
{
    [System.Serializable]
    public class OperationMessage : Message
    {
        public string op;
        public string topic;
    }
}