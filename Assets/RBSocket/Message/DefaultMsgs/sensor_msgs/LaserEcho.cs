using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class LaserEcho : ExtendMessage
    {
        public float[] echoes;
        public override string Type() { return "sensor_msgs/LaserEcho"; }
        public LaserEcho()
        {
            echoes = new float[0];
        }
    }
}