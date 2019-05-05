using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class ContactState : ExtendMessage
    {
        public string info;
        public string collision1_name;
        public string collision2_name;
        public RBS.Messages.geometry_msgs.Wrench[] wrenches;
        public RBS.Messages.geometry_msgs.Wrench total_wrench;
        public RBS.Messages.geometry_msgs.Vector3[] contact_positions;
        public RBS.Messages.geometry_msgs.Vector3[] contact_normals;
        public double[] depths;
        public override string Type() { return "gazebo_msgs/ContactState"; }
        public ContactState()
        {
            info = "";
            collision1_name = "";
            collision2_name = "";
            wrenches = new RBS.Messages.geometry_msgs.Wrench[0];
            total_wrench = new RBS.Messages.geometry_msgs.Wrench();
            contact_positions = new RBS.Messages.geometry_msgs.Vector3[0];
            contact_normals = new RBS.Messages.geometry_msgs.Vector3[0];
            depths = new double[0];
        }
    }
}