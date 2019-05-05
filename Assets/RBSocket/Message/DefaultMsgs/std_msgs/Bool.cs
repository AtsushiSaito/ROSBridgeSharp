using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class Bool : ExtendMessage
    {
        public bool data;
        public override string Type() { return "std_msgs/Bool"; }
        public Bool()
        {
            data = false;
        }
    }
}