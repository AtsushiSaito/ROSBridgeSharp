using System;

namespace RBS.Messages.std_msgs
{
    [System.Serializable]
    public class Header : ExtendMessage
    {
        public uint seq;
        public Time stamp;
        public string frame_id;
        public override string Type() { return "std_msgs/Header"; }
        public Header()
        {
            seq = 0;
            stamp = new Time();
            frame_id = "";
        }
    }
}