using System;

namespace RBS.Messages.tf2_msgs
{
    [System.Serializable]
    public class TF2Error : ExtendMessage
    {
        public uint NO_ERROR;
        public uint LOOKUP_ERROR;
        public uint CONNECTIVITY_ERROR;
        public uint EXTRAPOLATION_ERROR;
        public uint INVALID_ARGUMENT_ERROR;
        public uint TIMEOUT_ERROR;
        public uint TRANSFORM_ERROR;
        public uint error;
        public string error_string;
        public override string Type() { return "tf2_msgs/TF2Error"; }
        public TF2Error()
        {
            NO_ERROR = 0;
            LOOKUP_ERROR = 1;
            CONNECTIVITY_ERROR = 2;
            EXTRAPOLATION_ERROR = 3;
            INVALID_ARGUMENT_ERROR = 4;
            TIMEOUT_ERROR = 5;
            TRANSFORM_ERROR = 6;
            error = 0;
            error_string = "";
        }
    }
}