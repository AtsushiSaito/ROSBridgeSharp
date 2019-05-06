using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class ApplyBodyWrenchRequest : ExtendMessage
    {
        public string body_name;
        public string reference_frame;
        public RBS.Messages.geometry_msgs.Point reference_point;
        public RBS.Messages.geometry_msgs.Wrench wrench;
        public Time start_time;
        public Duration duration;
        public override string Type() { return "gazebo_msgs/ApplyBodyWrench"; }
        public ApplyBodyWrenchRequest()
        {
            body_name = "";
            reference_frame = "";
            reference_point = new RBS.Messages.geometry_msgs.Point();
            wrench = new RBS.Messages.geometry_msgs.Wrench();
            start_time = new Time();
            duration = new Duration();
        }
    }

    [System.Serializable]
    public class ApplyBodyWrenchResponse : ExtendMessage
    {
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/ApplyBodyWrench"; }
        public ApplyBodyWrenchResponse()
        {
            success = false;
            status_message = "";
        }
    }
}