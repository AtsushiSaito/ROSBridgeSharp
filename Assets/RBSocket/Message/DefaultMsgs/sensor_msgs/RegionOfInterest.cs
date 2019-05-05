using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class RegionOfInterest : ExtendMessage
    {
        public uint x_offset;
        public uint y_offset;
        public uint height;
        public uint width;
        public bool do_rectify;
        public override string Type() { return "sensor_msgs/RegionOfInterest"; }
        public RegionOfInterest()
        {
            x_offset = 0;
            y_offset = 0;
            height = 0;
            width = 0;
            do_rectify = false;
        }
    }
}