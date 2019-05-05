using System;

namespace RBS.Messages.raspimouse_ros_2
{
    [System.Serializable]
    public class MusicActionGoal : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalID goal_id;
        public RBS.Messages.raspimouse_ros_2.MusicGoal goal;
        public override string Type() { return "raspimouse_ros_2/MusicActionGoal"; }
        public MusicActionGoal()
        {
            header = new RBS.Messages.std_msgs.Header();
            goal_id = new RBS.Messages.actionlib_msgs.GoalID();
            goal = new RBS.Messages.raspimouse_ros_2.MusicGoal();
        }
    }
}