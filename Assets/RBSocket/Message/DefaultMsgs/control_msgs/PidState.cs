using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class PidState : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public Duration timestep;
        public double error;
        public double error_dot;
        public double p_error;
        public double i_error;
        public double d_error;
        public double p_term;
        public double i_term;
        public double d_term;
        public double i_max;
        public double i_min;
        public double output;
        public override string Type() { return "control_msgs/PidState"; }
        public PidState()
        {
            header = new RBS.Messages.std_msgs.Header();
            timestep = new Duration();
            error = 0.0f;
            error_dot = 0.0f;
            p_error = 0.0f;
            i_error = 0.0f;
            d_error = 0.0f;
            p_term = 0.0f;
            i_term = 0.0f;
            d_term = 0.0f;
            i_max = 0.0f;
            i_min = 0.0f;
            output = 0.0f;
        }
    }
}