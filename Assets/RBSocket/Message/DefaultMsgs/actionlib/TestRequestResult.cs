using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TestRequestResult : ExtendMessage
    {
        public int the_result;
        public bool is_simple_server;
        public override string Type() { return "actionlib/TestRequestResult"; }
        public TestRequestResult()
        {
            the_result = 0;
            is_simple_server = false;
        }
    }
}