using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class PointField : ExtendMessage
    {
        public uint INT8;
        public uint UINT8;
        public uint INT16;
        public uint UINT16;
        public uint INT32;
        public uint UINT32;
        public uint FLOAT32;
        public uint FLOAT64;
        public string name;
        public uint offset;
        public uint datatype;
        public uint count;
        public override string Type() { return "sensor_msgs/PointField"; }
        public PointField()
        {
            INT8 = 1;
            UINT8 = 2;
            INT16 = 3;
            UINT16 = 4;
            INT32 = 5;
            UINT32 = 6;
            FLOAT32 = 7;
            FLOAT64 = 8;
            name = "";
            offset = 0;
            datatype = 0;
            count = 0;
        }
    }
}