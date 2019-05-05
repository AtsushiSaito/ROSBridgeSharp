using System;

namespace RBS.Messages.move_base_msgs
{
    [System.Serializable]
    public class MoveBaseFeedback : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.PoseStamped base_position;
        public override string Type() { return "move_base_msgs/MoveBaseFeedback"; }
        public MoveBaseFeedback()
        {
            base_position = new RBS.Messages.geometry_msgs.PoseStamped();
        }
    }
}