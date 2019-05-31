using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RBS;
using RBS.Messages;

public class GetTimeServiceCall : MonoBehaviour
{
    private RBServiceClient<RBS.Messages.rosapi.GetTimeRequest, RBS.Messages.rosapi.GetTimeResponse> serviceClient;

    void Awake()
    {
        serviceClient = new RBServiceClient<RBS.Messages.rosapi.GetTimeRequest, RBS.Messages.rosapi.GetTimeResponse>("/rosapi/get_time");
    }

    void Update()
    {
        if (RBSocket.Instance.IsConnected)
        {
            RBS.Messages.rosapi.GetTimeRequest request_data = new RBS.Messages.rosapi.GetTimeRequest();
            RBS.Messages.rosapi.GetTimeResponse response_data = new RBS.Messages.rosapi.GetTimeResponse();
            serviceClient.Call(ref request_data, ref response_data);
            Debug.Log(response_data.time.nsecs);
        }
    }
}
