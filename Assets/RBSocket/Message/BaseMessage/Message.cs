using System;

namespace RBS.Messages
{
    [System.Serializable]
    public class Message
    {
    }

    [System.Serializable]
    public abstract class ExtendMessage : Message
    {
        public abstract string Type();
    }
}
