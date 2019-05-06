using System;

namespace RBS.Messages.diagnostic_msgs
{
    [System.Serializable]
    public class AddDiagnosticsRequest : ExtendMessage
    {
        public string load_namespace;
        public override string Type() { return "diagnostic_msgs/AddDiagnostics"; }
        public AddDiagnosticsRequest()
        {
            load_namespace = "";
        }
    }

    [System.Serializable]
    public class AddDiagnosticsResponse : ExtendMessage
    {
        public bool success;
        public string message;
        public override string Type() { return "diagnostic_msgs/AddDiagnostics"; }
        public AddDiagnosticsResponse()
        {
            success = false;
            message = "";
        }
    }
}