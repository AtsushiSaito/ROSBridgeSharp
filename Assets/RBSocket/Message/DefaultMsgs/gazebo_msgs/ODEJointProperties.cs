using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class ODEJointProperties : ExtendMessage
    {
        public double[] damping;
        public double[] hiStop;
        public double[] loStop;
        public double[] erp;
        public double[] cfm;
        public double[] stop_erp;
        public double[] stop_cfm;
        public double[] fudge_factor;
        public double[] fmax;
        public double[] vel;
        public override string Type() { return "gazebo_msgs/ODEJointProperties"; }
        public ODEJointProperties()
        {
            damping = new double[0];
            hiStop = new double[0];
            loStop = new double[0];
            erp = new double[0];
            cfm = new double[0];
            stop_erp = new double[0];
            stop_cfm = new double[0];
            fudge_factor = new double[0];
            fmax = new double[0];
            vel = new double[0];
        }
    }
}