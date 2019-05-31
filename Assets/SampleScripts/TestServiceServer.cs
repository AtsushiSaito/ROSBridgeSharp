using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RBS;
using RBS.Messages;

public class TestServiceServer : MonoBehaviour
{
    private RBServiceServer<RBS.Messages.std_srvs.SetBoolRequest, RBS.Messages.std_srvs.SetBoolResponse> serviceServer;

    void Awake()
    {
        serviceServer = new RBServiceServer<RBS.Messages.std_srvs.SetBoolRequest, RBS.Messages.std_srvs.SetBoolResponse>("/test_service", ServiceHandler);
    }

    RBS.Messages.std_srvs.SetBoolResponse ServiceHandler(RBS.Messages.std_srvs.SetBoolRequest request)
    {
        Debug.Log("Get data is " + request.data);
        RBS.Messages.std_srvs.SetBoolResponse response = new RBS.Messages.std_srvs.SetBoolResponse();
        response.message = "Test Success!";
        response.success = true;
        return response;
    }
}
