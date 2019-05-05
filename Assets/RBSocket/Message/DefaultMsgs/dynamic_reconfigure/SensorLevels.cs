using System;

namespace RBS.Messages.dynamic_reconfigure
{
    [System.Serializable]
    public class SensorLevels : ExtendMessage
    {
        public byte RECONFIGURE_CLOSE;
        public byte RECONFIGURE_STOP;
        public byte RECONFIGURE_RUNNING;
        public override string Type() { return "dynamic_reconfigure/SensorLevels"; }
        public SensorLevels()
        {
            RECONFIGURE_CLOSE = 3;
            RECONFIGURE_STOP = 1;
            RECONFIGURE_RUNNING = 0;
        }
    }
}