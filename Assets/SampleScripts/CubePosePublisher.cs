using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RBS;
using RBS.Messages;

public class CubePosePublisher : MonoBehaviour
{
    private RBPublisher<RBS.Messages.geometry_msgs.Pose> pub;
    public GameObject cubeObject;

    void Awake()
    {
        pub = new RBPublisher<RBS.Messages.geometry_msgs.Pose>("/cube_pose");
    }

    void Update()
    {
        if (RBSocket.Instance.IsConnected)
        {
            RBS.Messages.geometry_msgs.Pose pose = new RBS.Messages.geometry_msgs.Pose();
            pose.position.x = cubeObject.transform.position.x;
            pose.position.y = cubeObject.transform.position.y;
            pose.position.z = cubeObject.transform.position.z;
            pub.Publish(pose);
        }
    }
}
