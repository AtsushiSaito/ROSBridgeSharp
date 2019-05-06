using System;

namespace RBS.Messages.gazebo_msgs
{
    [System.Serializable]
    public class SetJointTrajectoryRequest : ExtendMessage
    {
        public string model_name;
        public RBS.Messages.trajectory_msgs.JointTrajectory joint_trajectory;
        public RBS.Messages.geometry_msgs.Pose model_pose;
        public bool set_model_pose;
        public bool disable_physics_updates;
        public override string Type() { return "gazebo_msgs/SetJointTrajectory"; }
        public SetJointTrajectoryRequest()
        {
            model_name = "";
            joint_trajectory = new RBS.Messages.trajectory_msgs.JointTrajectory();
            model_pose = new RBS.Messages.geometry_msgs.Pose();
            set_model_pose = false;
            disable_physics_updates = false;
        }
    }

    [System.Serializable]
    public class SetJointTrajectoryResponse : ExtendMessage
    {
        public bool success;
        public string status_message;
        public override string Type() { return "gazebo_msgs/SetJointTrajectory"; }
        public SetJointTrajectoryResponse()
        {
            success = false;
            status_message = "";
        }
    }
}