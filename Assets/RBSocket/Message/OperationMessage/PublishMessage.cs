namespace RBS.Messages
{
    [System.Serializable]
    public class PublishMessage<T> : Message where T : ExtendMessage
    {
        public string op = "publish";
        public string topic;
        public T msg;
    }

    [System.Serializable]
    public class Advertise : Message
    {
        public string op = "advertise";
        public string topic;
        public string type;
    }

    [System.Serializable]
    public class UnAdvertise : Message
    {
        public string op = "unadvertise";
        public string topic;
    }
}
