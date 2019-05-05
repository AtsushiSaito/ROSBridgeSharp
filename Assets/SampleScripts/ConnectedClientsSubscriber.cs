using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RBS;
using RBS.Messages;

public class ConnectedClientsSubscriber : MonoBehaviour
{
    private RBSubscriber<RBS.Messages.rosbridge_msgs.ConnectedClients> client_sub;

    void Awake()
    {
        client_sub = new RBSubscriber<RBS.Messages.rosbridge_msgs.ConnectedClients>("/connected_clients", callback);
    }

    void callback(RBS.Messages.rosbridge_msgs.ConnectedClients msg)
    {
        Debug.Log("Clients -> " + msg.clients.Length);
    }
}
