using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class String : ExtendMessage
    {
        public string data;
        public override string Type() { return "std_msgs/String"; }
        public String()
        {
            data = "";
        }
    }
}