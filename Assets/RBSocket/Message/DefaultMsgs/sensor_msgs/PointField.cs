using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class PointField : ExtendMessage
    {
        public byte INT8;
        public byte UINT8;
        public byte INT16;
        public byte UINT16;
        public byte INT32;
        public byte UINT32;
        public byte FLOAT32;
        public byte FLOAT64;
        public string name;
        public uint offset;
        public byte datatype;
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