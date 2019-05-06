using System.Collections.Generic;

namespace RBS.Messages
{
    [System.Serializable]
    public class CallServiceMessage : OperationMessage
    {
        public string service;
        public string args;
        public int fragment_size = int.MaxValue;
        public string compression = "none";
        public CallServiceMessage()
        {
            op = "call_service";
        }
    }

    [System.Serializable]
    public class CallServiceMessage<T> : OperationMessage where T : ExtendMessage
    {
        public string service;
        public T args;
        public int fragment_size = int.MaxValue;
        public string compression = "none";
        public CallServiceMessage()
        {
            op = "call_service";
        }
    }

    [System.Serializable]
    public class ServiceResponseMessage : OperationMessage
    {
        public string service;
        public string values;
        public bool result;
        public ServiceResponseMessage()
        {
            op = "service_response";
        }
    }

    [System.Serializable]
    public class ServiceResponseMessage<T> : OperationMessage where T : ExtendMessage
    {
        public string service;
        public T values;
        public bool result;
        public ServiceResponseMessage()
        {
            op = "service_response";
        }
    }
}
