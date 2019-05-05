using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class Joy : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public float[] axes;
        public int[] buttons;
        public override string Type() { return "sensor_msgs/Joy"; }
        public Joy()
        {
            header = new RBS.Messages.std_msgs.Header();
            axes = new float[0];
            buttons = new int[0];
        }
    }
}