using System;

namespace RBS.Messages.raspimouse_gamepad_teach_and_replay_msgs
{
    [System.Serializable]
    public class RaspiMouseIMUEvent : ExtendMessage
    {
        public RBS.Messages.raspimouse_ros_2.LightSensorValues observation_lightsensor;
        public RBS.Messages.sensor_msgs.Imu observation_imu;
        public RBS.Messages.geometry_msgs.Twist action;
        public override string Type() { return "raspimouse_gamepad_teach_and_replay_msgs/RaspiMouseIMUEvent"; }
        public RaspiMouseIMUEvent()
        {
            observation_lightsensor = new RBS.Messages.raspimouse_ros_2.LightSensorValues();
            observation_imu = new RBS.Messages.sensor_msgs.Imu();
            action = new RBS.Messages.geometry_msgs.Twist();
        }
    }
}