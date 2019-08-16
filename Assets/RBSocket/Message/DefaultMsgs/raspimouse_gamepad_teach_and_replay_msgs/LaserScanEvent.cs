using System;

namespace RBS.Messages.raspimouse_gamepad_teach_and_replay_msgs
{
    [System.Serializable]
    public class LaserScanEvent : ExtendMessage
    {
        public RBS.Messages.sensor_msgs.LaserScan observation;
        public RBS.Messages.geometry_msgs.Twist action;
        public override string Type() { return "raspimouse_gamepad_teach_and_replay_msgs/LaserScanEvent"; }
        public LaserScanEvent()
        {
            observation = new RBS.Messages.sensor_msgs.LaserScan();
            action = new RBS.Messages.geometry_msgs.Twist();
        }
    }
}