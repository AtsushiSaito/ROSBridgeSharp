using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class SearchParamRequest : ExtendMessage
    {
        public string name;
        public override string Type() { return "rosapi/SearchParam"; }
        public SearchParamRequest()
        {
            name = "";
        }
    }

    [System.Serializable]
    public class SearchParamResponse : ExtendMessage
    {
        public string global_name;
        public override string Type() { return "rosapi/SearchParam"; }
        public SearchParamResponse()
        {
            global_name = "";
        }
    }
}