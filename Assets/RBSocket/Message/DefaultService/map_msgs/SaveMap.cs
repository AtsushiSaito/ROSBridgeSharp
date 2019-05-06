using System;

namespace RBS.Messages.map_msgs
{
    [System.Serializable]
    public class SaveMapRequest : ExtendMessage
    {
        public RBS.Messages.std_msgs.String filename;
        public override string Type() { return "map_msgs/SaveMap"; }
        public SaveMapRequest()
        {
            filename = new RBS.Messages.std_msgs.String();
        }
    }

    [System.Serializable]
    public class SaveMapResponse : ExtendMessage
    {
        public override string Type() { return "map_msgs/SaveMap"; }
        public SaveMapResponse()
        {
        }
    }
}