namespace ROSBridgeSharp.Messages
{
    [System.Serializable]
    public class Time : ExtendMessage
    {
        public uint secs;
        public uint nsecs;
        public override string Type() { return "std_msgs/Time"; }
    }
}