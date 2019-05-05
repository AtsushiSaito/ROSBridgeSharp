using System;

namespace RBS.Messages.pcl_msgs
{
    [System.Serializable]
    public class ModelCoefficients : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public float[] values;
        public override string Type() { return "pcl_msgs/ModelCoefficients"; }
        public ModelCoefficients()
        {
            header = new RBS.Messages.std_msgs.Header();
            values = new float[0];
        }
    }
}