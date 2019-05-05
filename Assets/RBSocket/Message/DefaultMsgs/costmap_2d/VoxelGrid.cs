using System;

namespace RBS.Messages.costmap_2d
{
    [System.Serializable]
    public class VoxelGrid : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public uint[] data;
        public RBS.Messages.geometry_msgs.Point32 origin;
        public RBS.Messages.geometry_msgs.Vector3 resolutions;
        public uint size_x;
        public uint size_y;
        public uint size_z;
        public override string Type() { return "costmap_2d/VoxelGrid"; }
        public VoxelGrid()
        {
            header = new RBS.Messages.std_msgs.Header();
            data = new uint[0];
            origin = new RBS.Messages.geometry_msgs.Point32();
            resolutions = new RBS.Messages.geometry_msgs.Vector3();
            size_x = 0;
            size_y = 0;
            size_z = 0;
        }
    }
}