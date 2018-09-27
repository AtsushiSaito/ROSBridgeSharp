using System;

namespace ROSBridgeSharp.Messages
{
    [System.Serializable]
    public class LightSensorValues : Message
    {
        public int right_forward;
        public int right_side;
        public int left_side;
        public int left_forward;
        public int sum_all;
        public int sum_forward;
    }
}