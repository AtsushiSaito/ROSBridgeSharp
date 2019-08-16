using System;

namespace RBS.Messages.visualization_msgs
{
    [System.Serializable]
    public class InteractiveMarkerUpdate : ExtendMessage
    {
        public byte KEEP_ALIVE;
        public byte UPDATE;
        public string server_id;
        public uint seq_num;
        public byte type;
        public RBS.Messages.visualization_msgs.InteractiveMarker[] markers;
        public RBS.Messages.visualization_msgs.InteractiveMarkerPose[] poses;
        public string[] erases;
        public override string Type() { return "visualization_msgs/InteractiveMarkerUpdate"; }
        public InteractiveMarkerUpdate()
        {
            KEEP_ALIVE = 0;
            UPDATE = 1;
            server_id = "";
            seq_num = 0;
            type = 0;
            markers = new RBS.Messages.visualization_msgs.InteractiveMarker[0];
            poses = new RBS.Messages.visualization_msgs.InteractiveMarkerPose[0];
            erases = new string[0];
        }
    }
}