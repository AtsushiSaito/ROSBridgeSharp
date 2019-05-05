using System;

namespace RBS.Messages.raspimouse_ros_2
{
    [System.Serializable]
    public class MusicAction : ExtendMessage
    {
        public RBS.Messages.raspimouse_ros_2.MusicActionGoal action_goal;
        public RBS.Messages.raspimouse_ros_2.MusicActionResult action_result;
        public RBS.Messages.raspimouse_ros_2.MusicActionFeedback action_feedback;
        public override string Type() { return "raspimouse_ros_2/MusicAction"; }
        public MusicAction()
        {
            action_goal = new RBS.Messages.raspimouse_ros_2.MusicActionGoal();
            action_result = new RBS.Messages.raspimouse_ros_2.MusicActionResult();
            action_feedback = new RBS.Messages.raspimouse_ros_2.MusicActionFeedback();
        }
    }
}