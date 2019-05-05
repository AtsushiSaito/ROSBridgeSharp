using System;

namespace RBS.Messages.rospy_tutorials
{
    [System.Serializable]
    public class HeaderString : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public string data;
        public override string Type() { return "rospy_tutorials/HeaderString"; }
        public HeaderString()
        {
            header = new RBS.Messages.std_msgs.Header();
            data = "";
        }
    }
}