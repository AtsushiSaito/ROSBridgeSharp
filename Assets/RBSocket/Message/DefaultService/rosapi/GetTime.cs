using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class GetTimeRequest : ExtendMessage
    {
        public override string Type() { return "rosapi/GetTime"; }
        public GetTimeRequest()
        {
        }
    }

    [System.Serializable]
    public class GetTimeResponse : ExtendMessage
    {
        public Time time;
        public override string Type() { return "rosapi/GetTime"; }
        public GetTimeResponse()
        {
            time = new Time();
        }
    }
}