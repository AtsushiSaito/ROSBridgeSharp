using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class SetParamRequest : ExtendMessage
    {
        public string name;
        public string value;
        public override string Type() { return "rosapi/SetParam"; }
        public SetParamRequest()
        {
            name = "";
            value = "";
        }
    }

    [System.Serializable]
    public class SetParamResponse : ExtendMessage
    {
        public override string Type() { return "rosapi/SetParam"; }
        public SetParamResponse()
        {
        }
    }
}