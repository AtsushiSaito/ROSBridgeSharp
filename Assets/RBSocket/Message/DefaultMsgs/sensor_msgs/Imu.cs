using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class Imu : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.Quaternion orientation;
        public double[] orientation_covariance;
        public RBS.Messages.geometry_msgs.Vector3 angular_velocity;
        public double[] angular_velocity_covariance;
        public RBS.Messages.geometry_msgs.Vector3 linear_acceleration;
        public double[] linear_acceleration_covariance;
        public override string Type() { return "sensor_msgs/Imu"; }
        public Imu()
        {
            header = new RBS.Messages.std_msgs.Header();
            orientation = new RBS.Messages.geometry_msgs.Quaternion();
            orientation_covariance = new double[9];
            angular_velocity = new RBS.Messages.geometry_msgs.Vector3();
            angular_velocity_covariance = new double[9];
            linear_acceleration = new RBS.Messages.geometry_msgs.Vector3();
            linear_acceleration_covariance = new double[9];
        }
    }
}