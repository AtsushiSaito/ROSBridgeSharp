using System;

namespace RBS.Messages.raspimouse_gamepad_teach_and_replay_msgs
{
    [System.Serializable]
    public class RaspiMouseIMULaserScanEvent : ExtendMessage
    {
        public RBS.Messages.raspimouse_ros_2.LightSensorValues observation_lightsensor;
        public RBS.Messages.sensor_msgs.LaserScan observation_laserscan;
        public RBS.Messages.sensor_msgs.Imu observation_imu;
        public RBS.Messages.sensor_msgs.MagneticField observation_magneticfield;
        public RBS.Messages.sensor_msgs.Temperature observation_temperature;
        public RBS.Messages.geometry_msgs.Twist action;
        public override string Type() { return "raspimouse_gamepad_teach_and_replay_msgs/RaspiMouseIMULaserScanEvent"; }
        public RaspiMouseIMULaserScanEvent()
        {
            observation_lightsensor = new RBS.Messages.raspimouse_ros_2.LightSensorValues();
            observation_laserscan = new RBS.Messages.sensor_msgs.LaserScan();
            observation_imu = new RBS.Messages.sensor_msgs.Imu();
            observation_magneticfield = new RBS.Messages.sensor_msgs.MagneticField();
            observation_temperature = new RBS.Messages.sensor_msgs.Temperature();
            action = new RBS.Messages.geometry_msgs.Twist();
        }
    }
}