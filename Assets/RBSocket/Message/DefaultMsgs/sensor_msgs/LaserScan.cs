using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class LaserScan : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public float angle_min;
        public float angle_max;
        public float angle_increment;
        public float time_increment;
        public float scan_time;
        public float range_min;
        public float range_max;
        public float[] ranges;
        public float[] intensities;
        public override string Type() { return "sensor_msgs/LaserScan"; }
        public LaserScan()
        {
            header = new RBS.Messages.std_msgs.Header();
            angle_min = 0.0f;
            angle_max = 0.0f;
            angle_increment = 0.0f;
            time_increment = 0.0f;
            scan_time = 0.0f;
            range_min = 0.0f;
            range_max = 0.0f;
            ranges = new float[0];
            intensities = new float[0];
        }
    }
}