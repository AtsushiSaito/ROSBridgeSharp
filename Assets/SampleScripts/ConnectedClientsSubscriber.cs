using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RBS;
using RBS.Messages;

public class ConnectedClientsSubscriber : MonoBehaviour
{
    private RBSubscriber<RBS.Messages.rosbridge_msgs.ConnectedClients> sub;

    void Awake()
    {
        sub = new RBSubscriber<RBS.Messages.rosbridge_msgs.ConnectedClients>("/connected_clients", CallBack);
    }

    void CallBack(RBS.Messages.rosbridge_msgs.ConnectedClients msg)
    {
        Debug.Log("Clients -> " + msg.clients.Length);
    }
}
