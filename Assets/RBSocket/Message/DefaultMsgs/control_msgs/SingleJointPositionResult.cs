using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class SingleJointPositionResult : ExtendMessage
    {
        public override string Type() { return "control_msgs/SingleJointPositionResult"; }
        public SingleJointPositionResult()
        {
        }
    }
}