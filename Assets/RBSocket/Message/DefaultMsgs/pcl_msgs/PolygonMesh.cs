using System;

namespace RBS.Messages.pcl_msgs
{
    [System.Serializable]
    public class PolygonMesh : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.sensor_msgs.PointCloud2 cloud;
        public RBS.Messages.pcl_msgs.Vertices[] polygons;
        public override string Type() { return "pcl_msgs/PolygonMesh"; }
        public PolygonMesh()
        {
            header = new RBS.Messages.std_msgs.Header();
            cloud = new RBS.Messages.sensor_msgs.PointCloud2();
            polygons = new RBS.Messages.pcl_msgs.Vertices[0];
        }
    }
}