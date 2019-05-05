using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class Polygon : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.Point32[] points;
        public override string Type() { return "geometry_msgs/Polygon"; }
        public Polygon()
        {
            points = new RBS.Messages.geometry_msgs.Point32[0];
        }
    }
}