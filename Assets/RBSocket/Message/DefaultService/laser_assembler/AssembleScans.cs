using System;

namespace RBS.Messages.laser_assembler
{
    [System.Serializable]
    public class AssembleScansRequest : ExtendMessage
    {
        public Time begin;
        public Time end;
        public override string Type() { return "laser_assembler/AssembleScans"; }
        public AssembleScansRequest()
        {
            begin = new Time();
            end = new Time();
        }
    }

    [System.Serializable]
    public class AssembleScansResponse : ExtendMessage
    {
        public RBS.Messages.sensor_msgs.PointCloud cloud;
        public override string Type() { return "laser_assembler/AssembleScans"; }
        public AssembleScansResponse()
        {
            cloud = new RBS.Messages.sensor_msgs.PointCloud();
        }
    }
}