using System;

namespace RBS.Messages.rosserial_msgs
{
    [System.Serializable]
    public class Log : ExtendMessage
    {
        public uint ROSDEBUG;
        public uint INFO;
        public uint WARN;
        public uint ERROR;
        public uint FATAL;
        public uint level;
        public string msg;
        public override string Type() { return "rosserial_msgs/Log"; }
        public Log()
        {
            ROSDEBUG = 0;
            INFO = 1;
            WARN = 2;
            ERROR = 3;
            FATAL = 4;
            level = 0;
            msg = "";
        }
    }
}