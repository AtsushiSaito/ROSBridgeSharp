using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class Image : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public uint height;
        public uint width;
        public string encoding;
        public byte is_bigendian;
        public uint step;
        public string data;
        public override string Type() { return "sensor_msgs/Image"; }
        public Image()
        {
            header = new RBS.Messages.std_msgs.Header();
            height = 0;
            width = 0;
            encoding = "";
            is_bigendian = 0;
            step = 0;
            data = "";
        }
    }
}