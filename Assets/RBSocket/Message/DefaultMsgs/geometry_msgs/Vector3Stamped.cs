using System;

namespace RBS.Messages.geometry_msgs
{
    [System.Serializable]
    public class Vector3Stamped : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.geometry_msgs.Vector3 vector;
        public override string Type() { return "geometry_msgs/Vector3Stamped"; }
        public Vector3Stamped()
        {
            header = new RBS.Messages.std_msgs.Header();
            vector = new RBS.Messages.geometry_msgs.Vector3();
        }
    }
}