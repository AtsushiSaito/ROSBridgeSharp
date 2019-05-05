using System;

namespace RBS.Messages.stereo_msgs
{
    [System.Serializable]
    public class DisparityImage : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.sensor_msgs.Image image;
        public float f;
        public float T;
        public RBS.Messages.sensor_msgs.RegionOfInterest valid_window;
        public float min_disparity;
        public float max_disparity;
        public float delta_d;
        public override string Type() { return "stereo_msgs/DisparityImage"; }
        public DisparityImage()
        {
            header = new RBS.Messages.std_msgs.Header();
            image = new RBS.Messages.sensor_msgs.Image();
            f = 0.0f;
            T = 0.0f;
            valid_window = new RBS.Messages.sensor_msgs.RegionOfInterest();
            min_disparity = 0.0f;
            max_disparity = 0.0f;
            delta_d = 0.0f;
        }
    }
}