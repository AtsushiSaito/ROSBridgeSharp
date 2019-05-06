using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class SetPhysicsPropertiesRequest : ExtendMessage
    {
        public double time_step;
        public double max_update_rate;
        public RBS.Messages.geometry_msgs.Vector3 gravity;
        public RBS.Messages.gazebo_msgs.ODEPhysics ode_config;
        public override string Type() { return "gazebo_msgs/SetPhysicsProperties"; }
        public SetPhysicsPropertiesRequest()
        {
            time_step = 0.0f;
            max_update_rate = 0.0f;
            gravity = new RBS.Messages.geometry_msgs.Vector3();
            ode_config = new RBS.Messages.gazebo_msgs.ODEPhysics();
        }
    }

    [System.Serializable]
    public class SetPhysicsPropertiesResponse : ExtendMessage
    {
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/SetPhysicsProperties"; }
        public SetPhysicsPropertiesResponse()
        {
            success = false;
            status_message = "";
        }
    }
}