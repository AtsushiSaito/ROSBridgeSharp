using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using RBS;
using RBS.Messages;

public class RBTransformBroadcaster
{
    private RBPublisher<RBS.Messages.tf2_msgs.TFMessage> transformPublisher;
    RBS.Messages.tf2_msgs.TFMessage tfMessage = new RBS.Messages.tf2_msgs.TFMessage();

    public RBTransformBroadcaster()
    {
        transformPublisher = new RBPublisher<RBS.Messages.tf2_msgs.TFMessage>("/tf");
        tfMessage.transforms = new RBS.Messages.geometry_msgs.TransformStamped[1];
    }

    public void SendTransform(RBS.Messages.geometry_msgs.Transform transform, RBS.Messages.Time time, string frameID, string childFrameID)
    {
        RBS.Messages.geometry_msgs.TransformStamped transformStamped = new RBS.Messages.geometry_msgs.TransformStamped();
        transformStamped.transform = transform;
        transformStamped.header.stamp = time;
        transformStamped.header.frame_id = frameID;
        transformStamped.child_frame_id = childFrameID;
        tfMessage.transforms[0] = transformStamped;
        transformPublisher.Publish(tfMessage);
    }

    public void SendTransform(UnityEngine.Transform transform, RBS.Messages.Time time, string frameID, string childFrameID)
    {
        RBS.Messages.geometry_msgs.TransformStamped transformStamped = new RBS.Messages.geometry_msgs.TransformStamped();
        RBS.Messages.geometry_msgs.Transform rosTransform = new RBS.Messages.geometry_msgs.Transform();
        rosTransform.translation.x = transform.position.x;
        rosTransform.translation.y = transform.position.y;
        rosTransform.translation.z = transform.position.z;
        rosTransform.rotation.w = transform.rotation.w;
        rosTransform.rotation.x = transform.rotation.x;
        rosTransform.rotation.y = transform.rotation.y;
        rosTransform.rotation.z = transform.rotation.z;
        transformStamped.transform = rosTransform;
        transformStamped.header.stamp = time;
        transformStamped.header.frame_id = frameID;
        transformStamped.child_frame_id = childFrameID;
        tfMessage.transforms[0] = transformStamped;
        transformPublisher.Publish(tfMessage);
    }
}