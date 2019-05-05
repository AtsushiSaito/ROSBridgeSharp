using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class CameraInfo : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public uint height;
        public uint width;
        public string distortion_model;
        public double[] D;
        public double[] K;
        public double[] R;
        public double[] P;
        public uint binning_x;
        public uint binning_y;
        public RBS.Messages.sensor_msgs.RegionOfInterest roi;
        public override string Type() { return "sensor_msgs/CameraInfo"; }
        public CameraInfo()
        {
            header = new RBS.Messages.std_msgs.Header();
            height = 0;
            width = 0;
            distortion_model = "";
            D = new double[0];
            K = new double[9];
            R = new double[9];
            P = new double[12];
            binning_x = 0;
            binning_y = 0;
            roi = new RBS.Messages.sensor_msgs.RegionOfInterest();
        }
    }
}