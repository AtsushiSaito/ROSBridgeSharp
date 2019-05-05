using System;

namespace RBS.Messages.smach_msgs
{
    [System.Serializable]
    public class SmachContainerInitialStatusCmd : ExtendMessage
    {
        public string path;
        public string[] initial_states;
        public string local_data;
        public override string Type() { return "smach_msgs/SmachContainerInitialStatusCmd"; }
        public SmachContainerInitialStatusCmd()
        {
            path = "";
            initial_states = new string[0];
            local_data = "";
        }
    }
}