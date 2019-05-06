using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class GetParamRequest : ExtendMessage
    {
        public string name;
        public string @default;
        public override string Type() { return "rosapi/GetParam"; }
        public GetParamRequest()
        {
            name = "";
            @default = "";
        }
    }

    [System.Serializable]
    public class GetParamResponse : ExtendMessage
    {
        public string value;
        public override string Type() { return "rosapi/GetParam"; }
        public GetParamResponse()
        {
            value = "";
        }
    }
}