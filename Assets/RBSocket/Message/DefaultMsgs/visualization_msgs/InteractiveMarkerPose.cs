using System;

namespace RBS.Messages.visualization_msgs
{
    [System.Serializable]
    public class InteractiveMarkerPose : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.Pose pose;
        public string name;
        public override string Type() { return "visualization_msgs/InteractiveMarkerPose"; }
        public InteractiveMarkerPose()
        {
            header = new RBS.Messages.std_msgs.Header();
            pose = new RBS.Messages.geometry_msgs.Pose();
            name = "";
        }
    }
}