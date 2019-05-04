namespace RBS.Messages
{
    [System.Serializable]
    public class Duration : ExtendMessage
    {
        public int secs;
        public int nsecs;
        public override string Type() { return "std_msgs/Duration"; }
    }
}