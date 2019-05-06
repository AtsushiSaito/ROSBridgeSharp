using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RBS;
using RBS.Messages;

public class GetTimeServiceCall : MonoBehaviour
{
    private RBServiceClient<RBS.Messages.rosapi.GetTimeRequest, RBS.Messages.rosapi.GetTimeResponse> service_client;

    // Start is called before the first frame update
    void Awake()
    {
        service_client = new RBServiceClient<RBS.Messages.rosapi.GetTimeRequest, RBS.Messages.rosapi.GetTimeResponse>("/rosapi/get_time");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(RBSocket.Instance.IsConnected);
        if (RBSocket.Instance.IsConnected)
        {
            RBS.Messages.rosapi.GetTimeRequest request_data = new RBS.Messages.rosapi.GetTimeRequest();
            RBS.Messages.rosapi.GetTimeResponse response_data = new RBS.Messages.rosapi.GetTimeResponse();
            service_client.Call(ref request_data, ref response_data);
            Debug.Log(response_data.time.nsecs);
        }
    }
}
