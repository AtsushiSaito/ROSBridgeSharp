using System;

namespace RBS.Messages.rospy_tutorials
{
    [System.Serializable]
    public class BadTwoIntsRequest : ExtendMessage
    {
        public int a;
        public int b;
        public override string Type() { return "rospy_tutorials/BadTwoInts"; }
        public BadTwoIntsRequest()
        {
            a = 0;
            b = 0;
        }
    }

    [System.Serializable]
    public class BadTwoIntsResponse : ExtendMessage
    {
        public int sum;
        public override string Type() { return "rospy_tutorials/BadTwoInts"; }
        public BadTwoIntsResponse()
        {
            sum = 0;
        }
    }
}