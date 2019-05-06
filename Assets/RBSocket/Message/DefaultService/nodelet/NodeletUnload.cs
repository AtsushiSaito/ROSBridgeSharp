using System;

namespace RBS.Messages.nodelet
{
    [System.Serializable]
    public class NodeletUnloadRequest : ExtendMessage
    {
        public string name;
        public override string Type() { return "nodelet/NodeletUnload"; }
        public NodeletUnloadRequest()
        {
            name = "";
        }
    }

    [System.Serializable]
    public class NodeletUnloadResponse : ExtendMessage
    {
        public bool success;
        public override string Type() { return "nodelet/NodeletUnload"; }
        public NodeletUnloadResponse()
        {
            success = false;
        }
    }
}