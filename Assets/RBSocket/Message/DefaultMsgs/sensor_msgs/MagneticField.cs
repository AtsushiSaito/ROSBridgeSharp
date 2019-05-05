using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class MagneticField : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.Vector3 magnetic_field;
        public double[] magnetic_field_covariance;
        public override string Type() { return "sensor_msgs/MagneticField"; }
        public MagneticField()
        {
            header = new RBS.Messages.std_msgs.Header();
            magnetic_field = new RBS.Messages.geometry_msgs.Vector3();
            magnetic_field_covariance = new double[9];
        }
    }
}