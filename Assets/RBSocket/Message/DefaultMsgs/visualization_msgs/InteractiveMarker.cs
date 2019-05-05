using System;

namespace RBS.Messages.visualization_msgs
{
    [System.Serializable]
    public class InteractiveMarker : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.Pose pose;
        public string name;
        public string description;
        public float scale;
        public RBS.Messages.visualization_msgs.MenuEntry[] menu_entries;
        public RBS.Messages.visualization_msgs.InteractiveMarkerControl[] controls;
        public override string Type() { return "visualization_msgs/InteractiveMarker"; }
        public InteractiveMarker()
        {
            header = new RBS.Messages.std_msgs.Header();
            pose = new RBS.Messages.geometry_msgs.Pose();
            name = "";
            description = "";
            scale = 0.0f;
            menu_entries = new RBS.Messages.visualization_msgs.MenuEntry[0];
            controls = new RBS.Messages.visualization_msgs.InteractiveMarkerControl[0];
        }
    }
}