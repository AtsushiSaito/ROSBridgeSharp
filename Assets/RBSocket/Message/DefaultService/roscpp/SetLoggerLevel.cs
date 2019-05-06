using System;

namespace RBS.Messages.roscpp
{
    [System.Serializable]
    public class SetLoggerLevelRequest : ExtendMessage
    {
        public string logger;
        public string level;
        public override string Type() { return "roscpp/SetLoggerLevel"; }
        public SetLoggerLevelRequest()
        {
            logger = "";
            level = "";
        }
    }

    [System.Serializable]
    public class SetLoggerLevelResponse : ExtendMessage
    {
        public override string Type() { return "roscpp/SetLoggerLevel"; }
        public SetLoggerLevelResponse()
        {
        }
    }
}