namespace RBS.Messages
{
    [System.Serializable]
    public class PublishMessage<T> : OperationMessage where T : ExtendMessage
    {
        public string topic;
        public T msg;
        public PublishMessage()
        {
            op = "publish";
        }
    }

    [System.Serializable]
    public class Advertise : OperationMessage
    {
        public string topic;
        public string type;
        public Advertise()
        {
            op = "advertise";
        }
    }

    [System.Serializable]
    public class UnAdvertise : OperationMessage
    {
        public string topic;
        public UnAdvertise()
        {
            op = "unadvertise";
        }
    }
}
