using System;

namespace RBS.Messages.visualization_msgs
{
    [System.Serializable]
    public class InteractiveMarkerControl : ExtendMessage
    {
        public byte INHERIT;
        public byte FIXED;
        public byte VIEW_FACING;
        public byte NONE;
        public byte MENU;
        public byte BUTTON;
        public byte MOVE_AXIS;
        public byte MOVE_PLANE;
        public byte ROTATE_AXIS;
        public byte MOVE_ROTATE;
        public byte MOVE_3D;
        public byte ROTATE_3D;
        public byte MOVE_ROTATE_3D;
        public string name;
        public RBS.Messages.geometry_msgs.Quaternion orientation;
        public byte orientation_mode;
        public byte interaction_mode;
        public bool always_visible;
        public RBS.Messages.visualization_msgs.Marker[] markers;
        public bool independent_marker_orientation;
        public string description;
        public override string Type() { return "visualization_msgs/InteractiveMarkerControl"; }
        public InteractiveMarkerControl()
        {
            INHERIT = 0;
            FIXED = 1;
            VIEW_FACING = 2;
            NONE = 0;
            MENU = 1;
            BUTTON = 2;
            MOVE_AXIS = 3;
            MOVE_PLANE = 4;
            ROTATE_AXIS = 5;
            MOVE_ROTATE = 6;
            MOVE_3D = 7;
            ROTATE_3D = 8;
            MOVE_ROTATE_3D = 9;
            name = "";
            orientation = new RBS.Messages.geometry_msgs.Quaternion();
            orientation_mode = 0;
            interaction_mode = 0;
            always_visible = false;
            markers = new RBS.Messages.visualization_msgs.Marker[0];
            independent_marker_orientation = false;
            description = "";
        }
    }
}