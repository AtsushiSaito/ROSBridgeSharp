using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RBS;
using RBS.Messages;

public class CubePoseTransformBroadcast : MonoBehaviour
{
    private RBTransformBroadcaster br;
    public GameObject cubeObject;

    private void Awake()
    {
        br = new RBTransformBroadcaster();
    }

    void Update()
    {
        if (RBSocket.Instance.IsConnected)
        {
            br.SendTransform(cubeObject.transform, new RBS.Time().Now(), "map", "cube");
        }
    }
}
