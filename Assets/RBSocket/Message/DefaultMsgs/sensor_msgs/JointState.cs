using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class JointState : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public string[] name;
        public double[] position;
        public double[] velocity;
        public double[] effort;
        public override string Type() { return "sensor_msgs/JointState"; }
        public JointState()
        {
            header = new RBS.Messages.std_msgs.Header();
            name = new string[0];
            position = new double[0];
            velocity = new double[0];
            effort = new double[0];
        }
    }
}