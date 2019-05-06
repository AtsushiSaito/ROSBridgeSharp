using System;

namespace RBS.Messages.laser_assembler
{
    [System.Serializable]
    public class AssembleScans2Request : ExtendMessage
    {
        public Time begin;
        public Time end;
        public override string Type() { return "laser_assembler/AssembleScans2"; }
        public AssembleScans2Request()
        {
            begin = new Time();
            end = new Time();
        }
    }

    [System.Serializable]
    public class AssembleScans2Response : ExtendMessage
    {
        public RBS.Messages.sensor_msgs.PointCloud2 cloud;
        public override string Type() { return "laser_assembler/AssembleScans2"; }
        public AssembleScans2Response()
        {
            cloud = new RBS.Messages.sensor_msgs.PointCloud2();
        }
    }
}