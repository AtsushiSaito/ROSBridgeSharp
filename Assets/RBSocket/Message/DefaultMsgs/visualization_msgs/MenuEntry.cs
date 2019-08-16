using System;

namespace RBS.Messages.visualization_msgs
{
    [System.Serializable]
    public class MenuEntry : ExtendMessage
    {
        public byte FEEDBACK;
        public byte ROSRUN;
        public byte ROSLAUNCH;
        public uint id;
        public uint parent_id;
        public string title;
        public string command;
        public byte command_type;
        public override string Type() { return "visualization_msgs/MenuEntry"; }
        public MenuEntry()
        {
            FEEDBACK = 0;
            ROSRUN = 1;
            ROSLAUNCH = 2;
            id = 0;
            parent_id = 0;
            title = "";
            command = "";
            command_type = 0;
        }
    }
}