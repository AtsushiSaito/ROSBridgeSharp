using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class JointControllerState : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public double set_point;
        public double process_value;
        public double process_value_dot;
        public double error;
        public double time_step;
        public double command;
        public double p;
        public double i;
        public double d;
        public double i_clamp;
        public bool antiwindup;
        public override string Type() { return "control_msgs/JointControllerState"; }
        public JointControllerState()
        {
            header = new RBS.Messages.std_msgs.Header();
            set_point = 0.0f;
            process_value = 0.0f;
            process_value_dot = 0.0f;
            error = 0.0f;
            time_step = 0.0f;
            command = 0.0f;
            p = 0.0f;
            i = 0.0f;
            d = 0.0f;
            i_clamp = 0.0f;
            antiwindup = false;
        }
    }
}