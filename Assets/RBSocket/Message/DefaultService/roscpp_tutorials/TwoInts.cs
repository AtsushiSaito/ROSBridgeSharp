using System;

namespace RBS.Messages.roscpp_tutorials
{
    [System.Serializable]
    public class TwoIntsRequest : ExtendMessage
    {
        public int a;
        public int b;
        public override string Type() { return "roscpp_tutorials/TwoInts"; }
        public TwoIntsRequest()
        {
            a = 0;
            b = 0;
        }
    }

    [System.Serializable]
    public class TwoIntsResponse : ExtendMessage
    {
        public int sum;
        public override string Type() { return "roscpp_tutorials/TwoInts"; }
        public TwoIntsResponse()
        {
            sum = 0;
        }
    }
}