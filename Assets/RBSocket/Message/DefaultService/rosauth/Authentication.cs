using System;

namespace RBS.Messages.rosauth
{
    [System.Serializable]
    public class AuthenticationRequest : ExtendMessage
    {
        public string mac;
        public string client;
        public string dest;
        public string rand;
        public Time t;
        public string level;
        public Time end;
        public override string Type() { return "rosauth/Authentication"; }
        public AuthenticationRequest()
        {
            mac = "";
            client = "";
            dest = "";
            rand = "";
            t = new Time();
            level = "";
            end = new Time();
        }
    }

    [System.Serializable]
    public class AuthenticationResponse : ExtendMessage
    {
        public bool authenticated;
        public override string Type() { return "rosauth/Authentication"; }
        public AuthenticationResponse()
        {
            authenticated = false;
        }
    }
}