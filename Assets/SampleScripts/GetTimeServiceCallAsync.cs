using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RBS;
using RBS.Messages;

public class GetTimeServiceCallAsync : MonoBehaviour
{
    private RBServiceAsyncClient<RBS.Messages.rosapi.GetTimeRequest, RBS.Messages.rosapi.GetTimeResponse> service_client;
    private bool isRequested;

    void Awake()
    {
        isRequested = false;
        service_client = new RBServiceAsyncClient<RBS.Messages.rosapi.GetTimeRequest, RBS.Messages.rosapi.GetTimeResponse>("/rosapi/get_time", service_callback);
    }

    void service_callback(RBS.Messages.rosapi.GetTimeResponse response)
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
            service_client.Call(ref request_data, ref response_data);
            isRequested = true;
        }
    }
}
