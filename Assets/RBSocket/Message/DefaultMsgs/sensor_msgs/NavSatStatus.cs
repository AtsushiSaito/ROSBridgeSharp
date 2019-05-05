using System;

namespace RBS.Messages.sensor_msgs
{
    [System.Serializable]
    public class NavSatStatus : ExtendMessage
    {
        public int STATUS_NO_FIX;
        public int STATUS_FIX;
        public int STATUS_SBAS_FIX;
        public int STATUS_GBAS_FIX;
        public uint SERVICE_GPS;
        public uint SERVICE_GLONASS;
        public uint SERVICE_COMPASS;
        public uint SERVICE_GALILEO;
        public int status;
        public uint service;
        public override string Type() { return "sensor_msgs/NavSatStatus"; }
        public NavSatStatus()
        {
            STATUS_NO_FIX = -1;
            STATUS_FIX = 0;
            STATUS_SBAS_FIX = 1;
            STATUS_GBAS_FIX = 2;
            SERVICE_GPS = 1;
            SERVICE_GLONASS = 2;
            SERVICE_COMPASS = 4;
            SERVICE_GALILEO = 8;
            status = 0;
            service = 0;
        }
    }
}