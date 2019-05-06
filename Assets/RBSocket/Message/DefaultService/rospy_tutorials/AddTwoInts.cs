using System;

namespace RBS.Messages.rospy_tutorials
{
    [System.Serializable]
    public class AddTwoIntsRequest : ExtendMessage
    {
        public int a;
        public int b;
        public override string Type() { return "rospy_tutorials/AddTwoInts"; }
        public AddTwoIntsRequest()
        {
            a = 0;
            b = 0;
        }
    }

    [System.Serializable]
    public class AddTwoIntsResponse : ExtendMessage
    {
        public int sum;
        public override string Type() { return "rospy_tutorials/AddTwoInts"; }
        public AddTwoIntsResponse()
        {
            sum = 0;
        }
    }
}