using System;

namespace RBS.Messages.raspimouse_gamepad_teach_and_replay_msgs
{
    [System.Serializable]
    public class RaspiMouseLaserScanEvent : ExtendMessage
    {
        public RBS.Messages.raspimouse_ros_2.LightSensorValues observation_lightsensor;
        public RBS.Messages.sensor_msgs.LaserScan observation_laserscan;
        public RBS.Messages.geometry_msgs.Twist action;
        public override string Type() { return "raspimouse_gamepad_teach_and_replay_msgs/RaspiMouseLaserScanEvent"; }
        public RaspiMouseLaserScanEvent()
        {
            observation_lightsensor = new RBS.Messages.raspimouse_ros_2.LightSensorValues();
            observation_laserscan = new RBS.Messages.sensor_msgs.LaserScan();
            action = new RBS.Messages.geometry_msgs.Twist();
        }
    }
}