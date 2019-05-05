using System;

namespace RBS.Messages.visualization_msgs
{
    [System.Serializable]
    public class InteractiveMarkerInit : ExtendMessage
    {
        public string server_id;
        public uint seq_num;
        public RBS.Messages.visualization_msgs.InteractiveMarker[] markers;
        public override string Type() { return "visualization_msgs/InteractiveMarkerInit"; }
        public InteractiveMarkerInit()
        {
            server_id = "";
            seq_num = 0;
            markers = new RBS.Messages.visualization_msgs.InteractiveMarker[0];
        }
    }
}