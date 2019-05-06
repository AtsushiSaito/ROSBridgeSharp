using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class SetCameraInfoRequest : ExtendMessage
    {
        public RBS.Messages.sensor_msgs.CameraInfo camera_info;
        public override string Type() { return "sensor_msgs/SetCameraInfo"; }
        public SetCameraInfoRequest()
        {
            camera_info = new RBS.Messages.sensor_msgs.CameraInfo();
        }
    }

    [System.Serializable]
    public class SetCameraInfoResponse : ExtendMessage
    {
        public bool success;
        public string status_message;
        public override string Type() { return "sensor_msgs/SetCameraInfo"; }
        public SetCameraInfoResponse()
        {
            success = false;
            status_message = "";
        }
    }
}