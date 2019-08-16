using System;

namespace RBS.Messages.visualization_msgs
{
    [System.Serializable]
    public class Marker : ExtendMessage
    {
        public byte ARROW;
        public byte CUBE;
        public byte SPHERE;
        public byte CYLINDER;
        public byte LINE_STRIP;
        public byte LINE_LIST;
        public byte CUBE_LIST;
        public byte SPHERE_LIST;
        public byte POINTS;
        public byte TEXT_VIEW_FACING;
        public byte MESH_RESOURCE;
        public byte TRIANGLE_LIST;
        public byte ADD;
        public byte MODIFY;
        public byte DELETE;
        public byte DELETEALL;
        public RBS.Messages.std_msgs.Header header;
        public string ns;
        public int id;
        public int type;
        public int action;
        public RBS.Messages.geometry_msgs.Pose pose;
        public RBS.Messages.geometry_msgs.Vector3 scale;
        public RBS.Messages.std_msgs.ColorRGBA color;
        public Duration lifetime;
        public bool frame_locked;
        public RBS.Messages.geometry_msgs.Point[] points;
        public RBS.Messages.std_msgs.ColorRGBA[] colors;
        public string text;
        public string mesh_resource;
        public bool mesh_use_embedded_materials;
        public override string Type() { return "visualization_msgs/Marker"; }
        public Marker()
        {
            ARROW = 0;
            CUBE = 1;
            SPHERE = 2;
            CYLINDER = 3;
            LINE_STRIP = 4;
            LINE_LIST = 5;
            CUBE_LIST = 6;
            SPHERE_LIST = 7;
            POINTS = 8;
            TEXT_VIEW_FACING = 9;
            MESH_RESOURCE = 10;
            TRIANGLE_LIST = 11;
            ADD = 0;
            MODIFY = 0;
            DELETE = 2;
            DELETEALL = 3;
            header = new RBS.Messages.std_msgs.Header();
            ns = "";
            id = 0;
            type = 0;
            action = 0;
            pose = new RBS.Messages.geometry_msgs.Pose();
            scale = new RBS.Messages.geometry_msgs.Vector3();
            color = new RBS.Messages.std_msgs.ColorRGBA();
            lifetime = new Duration();
            frame_locked = false;
            points = new RBS.Messages.geometry_msgs.Point[0];
            colors = new RBS.Messages.std_msgs.ColorRGBA[0];
            text = "";
            mesh_resource = "";
            mesh_use_embedded_materials = false;
        }
    }
}