using System;

namespace RBS.Messages.turtlebot3_msgs
{
    [System.Serializable]
    public class Sound : ExtendMessage
    {
        public uint OFF;
        public uint ON;
        public uint LOW_BATTERY;
        public uint ERROR;
        public uint BUTTON1;
        public uint BUTTON2;
        public uint value;
        public override string Type() { return "turtlebot3_msgs/Sound"; }
        public Sound()
        {
            OFF = 0;
            ON = 1;
            LOW_BATTERY = 2;
            ERROR = 3;
            BUTTON1 = 4;
            BUTTON2 = 5;
            value = 0;
        }
    }
}