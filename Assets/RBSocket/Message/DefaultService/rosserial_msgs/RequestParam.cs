using System;

namespace RBS.Messages.rosserial_msgs
{
    [System.Serializable]
    public class RequestParamRequest : ExtendMessage
    {
        public string name;
        public override string Type() { return "rosserial_msgs/RequestParam"; }
        public RequestParamRequest()
        {
            name = "";
        }
    }

    [System.Serializable]
    public class RequestParamResponse : ExtendMessage
    {
        public int[] ints;
        public float[] floats;
        public string[] strings;
        public override string Type() { return "rosserial_msgs/RequestParam"; }
        public RequestParamResponse()
        {
            ints = new int[0];
            floats = new float[0];
            strings = new string[0];
        }
    }
}