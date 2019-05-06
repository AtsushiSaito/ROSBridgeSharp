using System;

namespace RBS.Messages.tf
{
    [System.Serializable]
    public class FrameGraphRequest : ExtendMessage
    {
        public override string Type() { return "tf/FrameGraph"; }
        public FrameGraphRequest()
        {
        }
    }

    [System.Serializable]
    public class FrameGraphResponse : ExtendMessage
    {
        public string dot_graph;
        public override string Type() { return "tf/FrameGraph"; }
        public FrameGraphResponse()
        {
            dot_graph = "";
        }
    }
}