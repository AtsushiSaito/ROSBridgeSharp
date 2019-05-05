using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RBS;
using RBS.Messages;

public class CubePosePublisher : MonoBehaviour
{
    private RBPublisher<RBS.Messages.geometry_msgs.Pose> pose_pub;
    public GameObject cube;
    // Start is called before the first frame update
    void Awake()
    {
        pose_pub = new RBPublisher<RBS.Messages.geometry_msgs.Pose>("/pose");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(RBSocket.Instance.IsConnected);
        if (RBSocket.Instance.IsConnected) {

            RBS.Messages.geometry_msgs.Pose pose = new RBS.Messages.geometry_msgs.Pose();
            pose.position.x = cube.transform.position.x;
            pose.position.y = cube.transform.position.y;
            pose.position.z = cube.transform.position.z;
            pose_pub.publish(pose);
        }
    }
}
