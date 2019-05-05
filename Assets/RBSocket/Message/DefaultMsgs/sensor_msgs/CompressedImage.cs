using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class CompressedImage : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public string format;
        public uint[] data;
        public override string Type() { return "sensor_msgs/CompressedImage"; }
        public CompressedImage()
        {
            header = new RBS.Messages.std_msgs.Header();
            format = "";
            data = new uint[0];
        }
    }
}