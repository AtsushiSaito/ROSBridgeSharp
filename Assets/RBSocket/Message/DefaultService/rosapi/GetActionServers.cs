using System;

namespace RBS.Messages.rosapi
{
    [System.Serializable]
    public class GetActionServersRequest : ExtendMessage
    {
        public override string Type() { return "rosapi/GetActionServers"; }
        public GetActionServersRequest()
        {
        }
    }

    [System.Serializable]
    public class GetActionServersResponse : ExtendMessage
    {
        public string[] action_servers;
        public override string Type() { return "rosapi/GetActionServers"; }
        public GetActionServersResponse()
        {
            action_servers = new string[0];
        }
    }
}