using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class DeleteParamRequest : ExtendMessage
    {
        public string name;
        public override string Type() { return "rosapi/DeleteParam"; }
        public DeleteParamRequest()
        {
            name = "";
        }
    }

    [System.Serializable]
    public class DeleteParamResponse : ExtendMessage
    {
        public override string Type() { return "rosapi/DeleteParam"; }
        public DeleteParamResponse()
        {
        }
    }
}