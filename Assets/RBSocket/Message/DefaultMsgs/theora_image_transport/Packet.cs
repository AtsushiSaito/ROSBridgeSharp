using System;

namespace RBS.Messages.theora_image_transport
{
    [System.Serializable]
    public class Packet : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public string data;
        public int b_o_s;
        public int e_o_s;
        public int granulepos;
        public int packetno;
        public override string Type() { return "theora_image_transport/Packet"; }
        public Packet()
        {
            header = new RBS.Messages.std_msgs.Header();
            data = "";
            b_o_s = 0;
            e_o_s = 0;
            granulepos = 0;
            packetno = 0;
        }
    }
}