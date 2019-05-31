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
    public class PublishAdvertiseMessage : OperationMessage
    {
        public string topic;
        public string type;
        public PublishAdvertiseMessage()
        {
            op = "advertise";
        }
    }

    [System.Serializable]
    public class PublishUnAdvertiseMessage : OperationMessage
    {
        public string topic;
        public PublishUnAdvertiseMessage()
        {
            op = "unadvertise";
        }
    }
}
