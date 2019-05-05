using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class MultiDOFJointState : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public string[] joint_names;
        public RBS.Messages.geometry_msgs.Transform[] transforms;
        public RBS.Messages.geometry_msgs.Twist[] twist;
        public RBS.Messages.geometry_msgs.Wrench[] wrench;
        public override string Type() { return "sensor_msgs/MultiDOFJointState"; }
        public MultiDOFJointState()
        {
            header = new RBS.Messages.std_msgs.Header();
            joint_names = new string[0];
            transforms = new RBS.Messages.geometry_msgs.Transform[0];
            twist = new RBS.Messages.geometry_msgs.Twist[0];
            wrench = new RBS.Messages.geometry_msgs.Wrench[0];
        }
    }
}