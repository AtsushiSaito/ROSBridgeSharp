using System;

namespace RBS.Messages.turtlebot3_msgs
{
    [System.Serializable]
    public class VersionInfo : ExtendMessage
    {
        public string hardware;
        public string firmware;
        public string software;
        public override string Type() { return "turtlebot3_msgs/VersionInfo"; }
        public VersionInfo()
        {
            hardware = "";
            firmware = "";
            software = "";
        }
    }
}