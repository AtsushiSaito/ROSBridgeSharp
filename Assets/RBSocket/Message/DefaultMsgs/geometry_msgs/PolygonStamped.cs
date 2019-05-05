using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class PolygonStamped : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.Polygon polygon;
        public override string Type() { return "geometry_msgs/PolygonStamped"; }
        public PolygonStamped()
        {
            header = new RBS.Messages.std_msgs.Header();
            polygon = new RBS.Messages.geometry_msgs.Polygon();
        }
    }
}