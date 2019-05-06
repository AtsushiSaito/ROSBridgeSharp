using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class GetJointPropertiesRequest : ExtendMessage
    {
        public string joint_name;
        public override string Type() { return "gazebo_msgs/GetJointProperties"; }
        public GetJointPropertiesRequest()
        {
            joint_name = "";
        }
    }

    [System.Serializable]
    public class GetJointPropertiesResponse : ExtendMessage
    {
        public uint REVOLUTE;
        public uint CONTINUOUS;
        public uint PRISMATIC;
        public uint FIXED;
        public uint BALL;
        public uint UNIVERSAL;
        public uint type;
        public double[] damping;
        public double[] position;
        public double[] rate;
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/GetJointProperties"; }
        public GetJointPropertiesResponse()
        {
            REVOLUTE = 0;
            CONTINUOUS = 1;
            PRISMATIC = 2;
            FIXED = 3;
            BALL = 4;
            UNIVERSAL = 5;
            type = 0;
            damping = new double[0];
            position = new double[0];
            rate = new double[0];
            success = false;
            status_message = "";
        }
    }
}