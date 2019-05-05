using System;

namespace RBS.Messages.actionlib
{
    [System.Serializable]
    public class TestRequestGoal : ExtendMessage
    {
        public int TERMINATE_SUCCESS;
        public int TERMINATE_ABORTED;
        public int TERMINATE_REJECTED;
        public int TERMINATE_LOSE;
        public int TERMINATE_DROP;
        public int TERMINATE_EXCEPTION;
        public int terminate_status;
        public bool ignore_cancel;
        public string result_text;
        public int the_result;
        public bool is_simple_client;
        public Duration delay_accept;
        public Duration delay_terminate;
        public Duration pause_status;
        public override string Type() { return "actionlib/TestRequestGoal"; }
        public TestRequestGoal()
        {
            TERMINATE_SUCCESS = 0;
            TERMINATE_ABORTED = 1;
            TERMINATE_REJECTED = 2;
            TERMINATE_LOSE = 3;
            TERMINATE_DROP = 4;
            TERMINATE_EXCEPTION = 5;
            terminate_status = 0;
            ignore_cancel = false;
            result_text = "";
            the_result = 0;
            is_simple_client = false;
            delay_accept = new Duration();
            delay_terminate = new Duration();
            pause_status = new Duration();
        }
    }
}