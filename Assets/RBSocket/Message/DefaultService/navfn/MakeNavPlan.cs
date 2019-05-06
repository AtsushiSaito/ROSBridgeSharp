using System;

namespace RBS.Messages.navfn
{
    [System.Serializable]
    public class MakeNavPlanRequest : ExtendMessage
    {
        public RBS.Messages.geometry_msgs.PoseStamped start;
        public RBS.Messages.geometry_msgs.PoseStamped goal;
        public override string Type() { return "navfn/MakeNavPlan"; }
        public MakeNavPlanRequest()
        {
            start = new RBS.Messages.geometry_msgs.PoseStamped();
            goal = new RBS.Messages.geometry_msgs.PoseStamped();
        }
    }

    [System.Serializable]
    public class MakeNavPlanResponse : ExtendMessage
    {
        public uint plan_found;
        public string error_message;
        public RBS.Messages.geometry_msgs.PoseStamped[] path;
        public override string Type() { return "navfn/MakeNavPlan"; }
        public MakeNavPlanResponse()
        {
            plan_found = 0;
            error_message = "";
            path = new RBS.Messages.geometry_msgs.PoseStamped[0];
        }
    }
}