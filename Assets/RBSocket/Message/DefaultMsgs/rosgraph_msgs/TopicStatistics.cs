using System;

namespace RBS.Messages.rosgraph_msgs
{
    [System.Serializable]
    public class TopicStatistics : ExtendMessage
    {
        public string topic;
        public string node_pub;
        public string node_sub;
        public Time window_start;
        public Time window_stop;
        public int delivered_msgs;
        public int dropped_msgs;
        public int traffic;
        public Duration period_mean;
        public Duration period_stddev;
        public Duration period_max;
        public Duration stamp_age_mean;
        public Duration stamp_age_stddev;
        public Duration stamp_age_max;
        public override string Type() { return "rosgraph_msgs/TopicStatistics"; }
        public TopicStatistics()
        {
            topic = "";
            node_pub = "";
            node_sub = "";
            window_start = new Time();
            window_stop = new Time();
            delivered_msgs = 0;
            dropped_msgs = 0;
            traffic = 0;
            period_mean = new Duration();
            period_stddev = new Duration();
            period_max = new Duration();
            stamp_age_mean = new Duration();
            stamp_age_stddev = new Duration();
            stamp_age_max = new Duration();
        }
    }
}