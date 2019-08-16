using System;

namespace RBS.Messages.visualization_msgs
{
    [System.Serializable]
    public class ImageMarker : ExtendMessage
    {
        public byte CIRCLE;
        public byte LINE_STRIP;
        public byte LINE_LIST;
        public byte POLYGON;
        public byte POINTS;
        public byte ADD;
        public byte REMOVE;
        public RBS.Messages.std_msgs.Header header;
        public string ns;
        public int id;
        public int type;
        public int action;
        public RBS.Messages.geometry_msgs.Point position;
        public float scale;
        public RBS.Messages.std_msgs.ColorRGBA outline_color;
        public byte filled;
        public RBS.Messages.std_msgs.ColorRGBA fill_color;
        public Duration lifetime;
        public RBS.Messages.geometry_msgs.Point[] points;
        public RBS.Messages.std_msgs.ColorRGBA[] outline_colors;
        public override string Type() { return "visualization_msgs/ImageMarker"; }
        public ImageMarker()
        {
            CIRCLE = 0;
            LINE_STRIP = 1;
            LINE_LIST = 2;
            POLYGON = 3;
            POINTS = 4;
            ADD = 0;
            REMOVE = 1;
            header = new RBS.Messages.std_msgs.Header();
            ns = "";
            id = 0;
            type = 0;
            action = 0;
            position = new RBS.Messages.geometry_msgs.Point();
            scale = 0.0f;
            outline_color = new RBS.Messages.std_msgs.ColorRGBA();
            filled = 0;
            fill_color = new RBS.Messages.std_msgs.ColorRGBA();
            lifetime = new Duration();
            points = new RBS.Messages.geometry_msgs.Point[0];
            outline_colors = new RBS.Messages.std_msgs.ColorRGBA[0];
        }
    }
}