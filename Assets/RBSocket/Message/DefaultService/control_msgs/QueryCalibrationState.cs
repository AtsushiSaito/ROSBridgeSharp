using System;

namespace RBS.Messages.control_msgs
{
    [System.Serializable]
    public class QueryCalibrationStateRequest : ExtendMessage
    {
        public override string Type() { return "control_msgs/QueryCalibrationState"; }
        public QueryCalibrationStateRequest()
        {
        }
    }

    [System.Serializable]
    public class QueryCalibrationStateResponse : ExtendMessage
    {
        public bool is_calibrated;
        public override string Type() { return "control_msgs/QueryCalibrationState"; }
        public QueryCalibrationStateResponse()
        {
            is_calibrated = false;
        }
    }
}