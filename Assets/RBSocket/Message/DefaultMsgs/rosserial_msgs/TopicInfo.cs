using System;

namespace RBS.Messages.rosserial_msgs
{
    [System.Serializable]
    public class TopicInfo : ExtendMessage
    {
        public uint ID_PUBLISHER;
        public uint ID_SUBSCRIBER;
        public uint ID_SERVICE_SERVER;
        public uint ID_SERVICE_CLIENT;
        public uint ID_PARAMETER_REQUEST;
        public uint ID_LOG;
        public uint ID_TIME;
        public uint ID_TX_STOP;
        public uint topic_id;
        public string topic_name;
        public string message_type;
        public string md5sum;
        public int buffer_size;
        public override string Type() { return "rosserial_msgs/TopicInfo"; }
        public TopicInfo()
        {
            ID_PUBLISHER = 0;
            ID_SUBSCRIBER = 1;
            ID_SERVICE_SERVER = 2;
            ID_SERVICE_CLIENT = 4;
            ID_PARAMETER_REQUEST = 6;
            ID_LOG = 7;
            ID_TIME = 10;
            ID_TX_STOP = 11;
            topic_id = 0;
            topic_name = "";
            message_type = "";
            md5sum = "";
            buffer_size = 0;
        }
    }
}