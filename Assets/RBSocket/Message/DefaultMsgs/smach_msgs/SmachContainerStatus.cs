using System;

namespace RBS.Messages.smach_msgs
{
    [System.Serializable]
    public class SmachContainerStatus : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public string path;
        public string[] initial_states;
        public string[] active_states;
        public string local_data;
        public string info;
        public override string Type() { return "smach_msgs/SmachContainerStatus"; }
        public SmachContainerStatus()
        {
            header = new RBS.Messages.std_msgs.Header();
            path = "";
            initial_states = new string[0];
            active_states = new string[0];
            local_data = "";
            info = "";
        }
    }
}