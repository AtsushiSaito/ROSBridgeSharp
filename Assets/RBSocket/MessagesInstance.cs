using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using RBS;
using RBS.Messages;

public class MessagesInstance<T> where T : ExtendMessage, new()
{
    private string typeName;
    private T messageType;
    public MessagesInstance()
    {
        messageType = new T();
        typeName = messageType.Type();
    }
    public string TypeName
    {
        get { return typeName; }
    }
}