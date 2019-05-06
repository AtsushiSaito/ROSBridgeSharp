using System;

namespace RBS.Messages.nav_msgs
{
    [System.Serializable]
    public class GetPlanRequest : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.PoseStamped start;
        public RBS.Messages.geometry_msgs.PoseStamped goal;
        public float tolerance;
        public override string Type() { return "nav_msgs/GetPlan"; }
        public GetPlanRequest()
        {
            start = new RBS.Messages.geometry_msgs.PoseStamped();
            goal = new RBS.Messages.geometry_msgs.PoseStamped();
            tolerance = 0.0f;
        }
    }

    [System.Serializable]
    public class GetPlanResponse : ExtendMessage
    {
        public RBS.Messages.nav_msgs.Path plan;
        public override string Type() { return "nav_msgs/GetPlan"; }
        public GetPlanResponse()
        {
            plan = new RBS.Messages.nav_msgs.Path();
        }
    }
}