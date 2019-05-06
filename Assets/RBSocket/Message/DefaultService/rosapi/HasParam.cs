using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class HasParamRequest : ExtendMessage
    {
        public string name;
        public override string Type() { return "rosapi/HasParam"; }
        public HasParamRequest()
        {
            name = "";
        }
    }

    [System.Serializable]
    public class HasParamResponse : ExtendMessage
    {
        public bool exists;
        public override string Type() { return "rosapi/HasParam"; }
        public HasParamResponse()
        {
            exists = false;
        }
    }
}