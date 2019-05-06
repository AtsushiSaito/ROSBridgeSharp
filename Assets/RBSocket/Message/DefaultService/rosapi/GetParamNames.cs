using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class GetParamNamesRequest : ExtendMessage
    {
        public override string Type() { return "rosapi/GetParamNames"; }
        public GetParamNamesRequest()
        {
        }
    }

    [System.Serializable]
    public class GetParamNamesResponse : ExtendMessage
    {
        public string[] names;
        public override string Type() { return "rosapi/GetParamNames"; }
        public GetParamNamesResponse()
        {
            names = new string[0];
        }
    }
}