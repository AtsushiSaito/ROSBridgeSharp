using System;

namespace RBS.Messages.pcl_msgs
{
    [System.Serializable]
    public class PointIndices : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public int[] indices;
        public override string Type() { return "pcl_msgs/PointIndices"; }
        public PointIndices()
        {
            header = new RBS.Messages.std_msgs.Header();
            indices = new int[0];
        }
    }
}