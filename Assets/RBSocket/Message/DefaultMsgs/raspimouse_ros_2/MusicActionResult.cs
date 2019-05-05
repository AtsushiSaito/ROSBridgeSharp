using System;

namespace RBS.Messages.raspimouse_ros_2
{
    [System.Serializable]
    public class MusicActionResult : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.actionlib_msgs.GoalStatus status;
        public RBS.Messages.raspimouse_ros_2.MusicResult result;
        public override string Type() { return "raspimouse_ros_2/MusicActionResult"; }
        public MusicActionResult()
        {
            header = new RBS.Messages.std_msgs.Header();
            status = new RBS.Messages.actionlib_msgs.GoalStatus();
            result = new RBS.Messages.raspimouse_ros_2.MusicResult();
        }
    }
}