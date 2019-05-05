using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class PointHeadGoal : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.PointStamped target;
        public RBS.Messages.geometry_msgs.Vector3 pointing_axis;
        public string pointing_frame;
        public Duration min_duration;
        public double max_velocity;
        public override string Type() { return "control_msgs/PointHeadGoal"; }
        public PointHeadGoal()
        {
            target = new RBS.Messages.geometry_msgs.PointStamped();
            pointing_axis = new RBS.Messages.geometry_msgs.Vector3();
            pointing_frame = "";
            min_duration = new Duration();
            max_velocity = 0.0f;
        }
    }
}