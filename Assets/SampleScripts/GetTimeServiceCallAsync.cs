using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RBS;
using RBS.Messages;

public class GetTimeServiceCallAsync : MonoBehaviour
{
    private RBServiceAsyncClient<RBS.Messages.rosapi.GetTimeRequest, RBS.Messages.rosapi.GetTimeResponse> serviceClient;
    private bool isRequested;

    void Awake()
    {
        isRequested = false;
        serviceClient = new RBServiceAsyncClient<RBS.Messages.rosapi.GetTimeRequest, RBS.Messages.rosapi.GetTimeResponse>("/rosapi/get_time", serviceCallBack);
    }

    void serviceCallBack(RBS.Messages.rosapi.GetTimeResponse response)
    {
        Debug.Log(response.time.nsecs);
        isRequested = false;
    }

    void Update()
    {
        if (RBSocket.Instance.IsConnected && !isRequested)
        {
            RBS.Messages.rosapi.GetTimeRequest request_data = new RBS.Messages.rosapi.GetTimeRequest();
            RBS.Messages.rosapi.GetTimeResponse response_data = new RBS.Messages.rosapi.GetTimeResponse();
            serviceClient.Call(ref request_data, ref response_data);
            isRequested = true;
        }
    }
}
