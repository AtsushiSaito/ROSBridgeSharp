using System;

namespace RBS.Messages.dynamic_reconfigure
{
    [System.Serializable]
    public class ReconfigureRequest : ExtendMessage
    {
        public RBS.Messages.dynamic_reconfigure.Config config;
        public override string Type() { return "dynamic_reconfigure/Reconfigure"; }
        public ReconfigureRequest()
        {
            config = new RBS.Messages.dynamic_reconfigure.Config();
        }
    }

    [System.Serializable]
    public class ReconfigureResponse : ExtendMessage
    {
        public RBS.Messages.dynamic_reconfigure.Config config;
        public override string Type() { return "dynamic_reconfigure/Reconfigure"; }
        public ReconfigureResponse()
        {
            config = new RBS.Messages.dynamic_reconfigure.Config();
        }
    }
}