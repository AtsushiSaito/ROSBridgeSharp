using System;

namespace RBS.Messages.pcl_msgs
{
    [System.Serializable]
    public class Vertices : ExtendMessage
    {
        public uint[] vertices;
        public override string Type() { return "pcl_msgs/Vertices"; }
        public Vertices()
        {
            vertices = new uint[0];
        }
    }
}