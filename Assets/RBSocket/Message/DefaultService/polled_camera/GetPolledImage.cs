using System;

namespace RBS.Messages.polled_camera
{
    [System.Serializable]
    public class GetPolledImageRequest : ExtendMessage
    {
        public string response_namespace;
        public Duration timeout;
        public uint binning_x;
        public uint binning_y;
        public RBS.Messages.sensor_msgs.RegionOfInterest roi;
        public override string Type() { return "polled_camera/GetPolledImage"; }
        public GetPolledImageRequest()
        {
            response_namespace = "";
            timeout = new Duration();
            binning_x = 0;
            binning_y = 0;
            roi = new RBS.Messages.sensor_msgs.RegionOfInterest();
        }
    }

    [System.Serializable]
    public class GetPolledImageResponse : ExtendMessage
    {
        public bool success;
        public string status_message;
        public Time stamp;
        public override string Type() { return "polled_camera/GetPolledImage"; }
        public GetPolledImageResponse()
        {
            success = false;
            status_message = "";
            stamp = new Time();
        }
    }
}