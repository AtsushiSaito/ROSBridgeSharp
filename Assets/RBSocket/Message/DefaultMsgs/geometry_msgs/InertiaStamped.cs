using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class InertiaStamped : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.Inertia inertia;
        public override string Type() { return "geometry_msgs/InertiaStamped"; }
        public InertiaStamped()
        {
            header = new RBS.Messages.std_msgs.Header();
            inertia = new RBS.Messages.geometry_msgs.Inertia();
        }
    }
}