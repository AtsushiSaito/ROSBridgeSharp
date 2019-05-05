using System;

namespace RBS.Messages.smach_msgs
{
    [System.Serializable]
    public class SmachContainerStructure : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public string path;
        public string[] children;
        public string[] internal_outcomes;
        public string[] outcomes_from;
        public string[] outcomes_to;
        public string[] container_outcomes;
        public override string Type() { return "smach_msgs/SmachContainerStructure"; }
        public SmachContainerStructure()
        {
            header = new RBS.Messages.std_msgs.Header();
            path = "";
            children = new string[0];
            internal_outcomes = new string[0];
            outcomes_from = new string[0];
            outcomes_to = new string[0];
            container_outcomes = new string[0];
        }
    }
}