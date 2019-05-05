namespace RBS.Messages
{
    [System.Serializable]
    public class SubscribeOperationMessage : Message
    {
        public string op = "subscribe";
        public string topic;
        public string id;
        public string type;
        public string compression = "none";
        public int throttle_rate = 0;
        public int queue_length = 1;
        public int fragment_size = int.MaxValue;
    }

    [System.Serializable]
    public class UnSubscribeOperationMessage : Message
    {
        public string op = "unsubscribe";
        public string topic;
        public string id;
    }

    [System.Serializable]
    public class SubscribeMessage : Message
    {
        public string op;
        public string topic;
        public string msg;
    }

    [System.Serializable]
    public class SubscribeMessage<T> : Message where T : Message
    {
        public string op;
        public string topic;
        public T msg;
    }
}
