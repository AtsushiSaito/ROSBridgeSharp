using System;

namespace RBS.Messages.raspimouse_ros_2
{
    [System.Serializable]
    public class MusicActionFeedback : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.raspimouse_ros_2.MusicFeedback feedback;
        public override string Type() { return "raspimouse_ros_2/MusicActionFeedback"; }
        public MusicActionFeedback()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            feedback = new RBS.Messages.raspimouse_ros_2.MusicFeedback();
        }
    }
}