using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class GetPhysicsPropertiesRequest : ExtendMessage
    {
        public override string Type() { return "gazebo_msgs/GetPhysicsProperties"; }
        public GetPhysicsPropertiesRequest()
        {
        }
    }

    [System.Serializable]
    public class GetPhysicsPropertiesResponse : ExtendMessage
    {
        public double time_step;
        public bool pause;
        public double max_update_rate;
        public RBS.Messages.geometry_msgs.Vector3 gravity;
        public RBS.Messages.gazebo_msgs.ODEPhysics ode_config;
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/GetPhysicsProperties"; }
        public GetPhysicsPropertiesResponse()
        {
            time_step = 0.0f;
            pause = false;
            max_update_rate = 0.0f;
            gravity = new RBS.Messages.geometry_msgs.Vector3();
            ode_config = new RBS.Messages.gazebo_msgs.ODEPhysics();
            success = false;
            status_message = "";
        }
    }
}