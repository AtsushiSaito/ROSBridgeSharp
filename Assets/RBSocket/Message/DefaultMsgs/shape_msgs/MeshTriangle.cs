using System;

namespace RBS.Messages.shape_msgs
{
    [System.Serializable]
    public class MeshTriangle : ExtendMessage
    {
        public uint[] vertex_indices;
        public override string Type() { return "shape_msgs/MeshTriangle"; }
        public MeshTriangle()
        {
            vertex_indices = new uint[3];
        }
    }
}