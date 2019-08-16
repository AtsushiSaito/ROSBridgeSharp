using System;

namespace RBS.Messages.visualization_msgs
{
    [System.Serializable]
    public class InteractiveMarkerFeedback : ExtendMessage
    {
        public byte KEEP_ALIVE;
        public byte POSE_UPDATE;
        public byte MENU_SELECT;
        public byte BUTTON_CLICK;
        public byte MOUSE_DOWN;
        public byte MOUSE_UP;
        public RBS.Messages.std_msgs.Header header;
        public string client_id;
        public string marker_name;
        public string control_name;
        public byte event_type;
        public RBS.Messages.geometry_msgs.Pose pose;
        public uint menu_entry_id;
        public RBS.Messages.geometry_msgs.Point mouse_point;
        public bool mouse_point_valid;
        public override string Type() { return "visualization_msgs/InteractiveMarkerFeedback"; }
        public InteractiveMarkerFeedback()
        {
            KEEP_ALIVE = 0;
            POSE_UPDATE = 1;
            MENU_SELECT = 2;
            BUTTON_CLICK = 3;
            MOUSE_DOWN = 4;
            MOUSE_UP = 5;
            header = new RBS.Messages.std_msgs.Header();
            client_id = "";
            marker_name = "";
            control_name = "";
            event_type = 0;
            pose = new RBS.Messages.geometry_msgs.Pose();
            menu_entry_id = 0;
            mouse_point = new RBS.Messages.geometry_msgs.Point();
            mouse_point_valid = false;
        }
    }
}