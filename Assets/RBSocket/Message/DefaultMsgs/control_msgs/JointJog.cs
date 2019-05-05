using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class JointJog : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public string[] joint_names;
        public double[] displacements;
        public double[] velocities;
        public double duration;
        public override string Type() { return "control_msgs/JointJog"; }
        public JointJog()
        {
            header = new RBS.Messages.std_msgs.Header();
            joint_names = new string[0];
            displacements = new double[0];
            velocities = new double[0];
            duration = 0.0f;
        }
    }
}