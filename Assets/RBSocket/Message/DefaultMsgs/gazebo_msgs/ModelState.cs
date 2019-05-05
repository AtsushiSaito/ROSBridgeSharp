using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class ModelState : ExtendMessage
    {
        public string model_name;
        public RBS.Messages.geometry_msgs.Pose pose;
        public RBS.Messages.geometry_msgs.Twist twist;
        public string reference_frame;
        public override string Type() { return "gazebo_msgs/ModelState"; }
        public ModelState()
        {
            model_name = "";
            pose = new RBS.Messages.geometry_msgs.Pose();
            twist = new RBS.Messages.geometry_msgs.Twist();
            reference_frame = "";
        }
    }
}