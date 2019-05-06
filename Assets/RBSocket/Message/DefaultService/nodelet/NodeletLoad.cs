using System;

namespace RBS.Messages.nodelet
{
    [System.Serializable]
    public class NodeletLoadRequest : ExtendMessage
    {
        public string name;
        public string type;
        public string[] remap_source_args;
        public string[] remap_target_args;
        public string[] my_argv;
        public string bond_id;
        public override string Type() { return "nodelet/NodeletLoad"; }
        public NodeletLoadRequest()
        {
            name = "";
            type = "";
            remap_source_args = new string[0];
            remap_target_args = new string[0];
            my_argv = new string[0];
            bond_id = "";
        }
    }

    [System.Serializable]
    public class NodeletLoadResponse : ExtendMessage
    {
        public bool success;
        public override string Type() { return "nodelet/NodeletLoad"; }
        public NodeletLoadResponse()
        {
            success = false;
        }
    }
}