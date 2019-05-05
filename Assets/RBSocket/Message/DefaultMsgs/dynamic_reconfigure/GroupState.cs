using System;

namespace RBS.Messages.dynamic_reconfigure
{
    [System.Serializable]
    public class GroupState : ExtendMessage
    {
        public string name;
        public bool state;
        public int id;
        public int parent;
        public override string Type() { return "dynamic_reconfigure/GroupState"; }
        public GroupState()
        {
            name = "";
            state = false;
            id = 0;
            parent = 0;
        }
    }
}