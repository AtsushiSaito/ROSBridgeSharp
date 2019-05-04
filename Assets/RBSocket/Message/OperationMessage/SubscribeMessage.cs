namespace RBS.Messages
{
    [System.Serializable]
    public class QueueSubscribeMessage : Message
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
