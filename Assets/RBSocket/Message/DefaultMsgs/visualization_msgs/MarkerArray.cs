using System;

namespace RBS.Messages.visualization_msgs
{
    [System.Serializable]
    public class MarkerArray : ExtendMessage
    {
        public RBS.Messages.visualization_msgs.Marker[] markers;
        public override string Type() { return "visualization_msgs/MarkerArray"; }
        public MarkerArray()
        {
            markers = new RBS.Messages.visualization_msgs.Marker[0];
        }
    }
}