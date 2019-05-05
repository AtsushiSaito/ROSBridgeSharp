using System;

namespace RBS.Messages.move_base_msgs
{
    [System.Serializable]
    public class MoveBaseGoal : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.PoseStamped target_pose;
        public override string Type() { return "move_base_msgs/MoveBaseGoal"; }
        public MoveBaseGoal()
        {
            target_pose = new RBS.Messages.geometry_msgs.PoseStamped();
        }
    }
}