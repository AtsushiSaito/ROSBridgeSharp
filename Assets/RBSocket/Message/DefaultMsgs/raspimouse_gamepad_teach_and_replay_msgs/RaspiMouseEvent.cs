using System;

namespace RBS.Messages.raspimouse_gamepad_teach_and_replay_msgs
{
    [System.Serializable]
    public class RaspiMouseEvent : ExtendMessage
    {
        public RBS.Messages.raspimouse_ros_2.LightSensorValues observation;
        public RBS.Messages.geometry_msgs.Twist action;
        public override string Type() { return "raspimouse_gamepad_teach_and_replay_msgs/RaspiMouseEvent"; }
        public RaspiMouseEvent()
        {
            observation = new RBS.Messages.raspimouse_ros_2.LightSensorValues();
            action = new RBS.Messages.geometry_msgs.Twist();
        }
    }
}