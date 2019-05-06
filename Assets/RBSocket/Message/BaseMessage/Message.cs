using System;

namespace RBS.Messages
{
    [System.Serializable]
    public class Message
    {
    }

    [System.Serializable]
    public abstract class ExtendMessage : Message
    {
        public abstract string Type();
    }

    [System.Serializable]
    public class OperationMessage : Message
    {
        public string op;
        public string id;
    }
}
