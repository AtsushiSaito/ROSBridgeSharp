using System;

namespace RBS.Messages.roscpp
{
    [System.Serializable]
    public class GetLoggersRequest : ExtendMessage
    {
        public override string Type() { return "roscpp/GetLoggers"; }
        public GetLoggersRequest()
        {
        }
    }

    [System.Serializable]
    public class GetLoggersResponse : ExtendMessage
    {
        public RBS.Messages.roscpp.Logger[] loggers;
        public override string Type() { return "roscpp/GetLoggers"; }
        public GetLoggersResponse()
        {
            loggers = new RBS.Messages.roscpp.Logger[0];
        }
    }
}