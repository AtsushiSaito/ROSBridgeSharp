using System;

namespace RBS.Messages.shape_msgs
{
    [System.Serializable]
    public class Mesh : ExtendMessage
    {
        public RBS.Messages.shape_msgs.MeshTriangle[] triangles;
        public RBS.Messages.geometry_msgs.Point[] vertices;
        public override string Type() { return "shape_msgs/Mesh"; }
        public Mesh()
        {
            triangles = new RBS.Messages.shape_msgs.MeshTriangle[0];
            vertices = new RBS.Messages.geometry_msgs.Point[0];
        }
    }
}