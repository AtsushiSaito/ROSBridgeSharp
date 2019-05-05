using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class SingleJointPositionGoal : ExtendMessage
    {
        public double position;
        public Duration min_duration;
        public double max_velocity;
        public override string Type() { return "control_msgs/SingleJointPositionGoal"; }
        public SingleJointPositionGoal()
        {
            position = 0.0f;
            min_duration = new Duration();
            max_velocity = 0.0f;
        }
    }
}