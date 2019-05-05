using System;

namespace RBS.Messages.rosgraph_msgs
{
    [System.Serializable]
    public class Log : ExtendMessage
    {
        public byte DEBUG;
        public byte INFO;
        public byte WARN;
        public byte ERROR;
        public byte FATAL;
        public RBS.Messages.std_msgs.Header header;
        public byte level;
        public string name;
        public string msg;
        public string file;
        public string function;
        public uint line;
        public string[] topics;
        public override string Type() { return "rosgraph_msgs/Log"; }
        public Log()
        {
            DEBUG = 1;
            INFO = 2;
            WARN = 4;
            ERROR = 8;
            FATAL = 16;
            header = new RBS.Messages.std_msgs.Header();
            level = 0;
            name = "";
            msg = "";
            file = "";
            function = "";
            line = 0;
            topics = new string[0];
        }
    }
}