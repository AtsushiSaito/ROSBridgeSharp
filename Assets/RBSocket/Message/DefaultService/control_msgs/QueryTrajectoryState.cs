using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class QueryTrajectoryStateRequest : ExtendMessage
    {
        public Time time;
        public override string Type() { return "control_msgs/QueryTrajectoryState"; }
        public QueryTrajectoryStateRequest()
        {
            time = new Time();
        }
    }

    [System.Serializable]
    public class QueryTrajectoryStateResponse : ExtendMessage
    {
        public string[] name;
        public double[] position;
        public double[] velocity;
        public double[] acceleration;
        public override string Type() { return "control_msgs/QueryTrajectoryState"; }
        public QueryTrajectoryStateResponse()
        {
            name = new string[0];
            position = new double[0];
            velocity = new double[0];
            acceleration = new double[0];
        }
    }
}