using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class NodesRequest : ExtendMessage
    {
        public override string Type() { return "rosapi/Nodes"; }
        public NodesRequest()
        {
        }
    }

    [System.Serializable]
    public class NodesResponse : ExtendMessage
    {
        public string[] nodes;
        public override string Type() { return "rosapi/Nodes"; }
        public NodesResponse()
        {
            nodes = new string[0];
        }
    }
}