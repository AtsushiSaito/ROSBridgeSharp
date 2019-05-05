using System;

namespace RBS.Messages.roscpp
{
    [System.Serializable]
    public class Logger : ExtendMessage
    {
        public string name;
        public string level;
        public override string Type() { return "roscpp/Logger"; }
        public Logger()
        {
            name = "";
            level = "";
        }
    }
}