using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class ContactsState : ExtendMessage
    {
        public RBS.Messages.std_msgs.Header header;
        public RBS.Messages.gazebo_msgs.ContactState[] states;
        public override string Type() { return "gazebo_msgs/ContactsState"; }
        public ContactsState()
        {
            header = new RBS.Messages.std_msgs.Header();
            states = new RBS.Messages.gazebo_msgs.ContactState[0];
        }
    }
}