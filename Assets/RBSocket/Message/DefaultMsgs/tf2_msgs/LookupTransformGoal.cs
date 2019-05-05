using System;

namespace RBS.Messages.tf2_msgs
{
    [System.Serializable]
    public class LookupTransformGoal : ExtendMessage
    {
        public string target_frame;
        public string source_frame;
        public Time source_time;
        public Duration timeout;
        public Time target_time;
        public string fixed_frame;
        public bool advanced;
        public override string Type() { return "tf2_msgs/LookupTransformGoal"; }
        public LookupTransformGoal()
        {
            target_frame = "";
            source_frame = "";
            source_time = new Time();
            timeout = new Duration();
            target_time = new Time();
            fixed_frame = "";
            advanced = false;
        }
    }
}