using System;

namespace RBS.Messages.nodelet
{
    [System.Serializable]
    public class NodeletListRequest : ExtendMessage
    {
        public override string Type() { return "nodelet/NodeletList"; }
        public NodeletListRequest()
        {
        }
    }

    [System.Serializable]
    public class NodeletListResponse : ExtendMessage
    {
        public string[] nodelets;
        public override string Type() { return "nodelet/NodeletList"; }
        public NodeletListResponse()
        {
            nodelets = new string[0];
        }
    }
}