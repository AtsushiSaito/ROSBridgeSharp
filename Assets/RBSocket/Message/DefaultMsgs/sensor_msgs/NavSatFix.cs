using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class NavSatFix : ExtendMessage
    {
        public uint COVARIANCE_TYPE_UNKNOWN;
        public uint COVARIANCE_TYPE_APPROXIMATED;
        public uint COVARIANCE_TYPE_DIAGONAL_KNOWN;
        public uint COVARIANCE_TYPE_KNOWN;
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.sensor_msgs.NavSatStatus status;
        public double latitude;
        public double longitude;
        public double altitude;
        public double[] position_covariance;
        public uint position_covariance_type;
        public override string Type() { return "sensor_msgs/NavSatFix"; }
        public NavSatFix()
        {
            COVARIANCE_TYPE_UNKNOWN = 0;
            COVARIANCE_TYPE_APPROXIMATED = 1;
            COVARIANCE_TYPE_DIAGONAL_KNOWN = 2;
            COVARIANCE_TYPE_KNOWN = 3;
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.sensor_msgs.NavSatStatus();
            latitude = 0.0f;
            longitude = 0.0f;
            altitude = 0.0f;
            position_covariance = new double[9];
            position_covariance_type = 0;
        }
    }
}