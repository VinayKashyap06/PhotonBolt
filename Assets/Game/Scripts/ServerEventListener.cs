using UnityEngine;
using System.Collections;

public class ServerEventListener : Bolt.GlobalEventListener
{
    public override void OnEvent(NewPlayerJoinedEvent evnt)
    {
        Debug.Log(evnt.Message);
    }

}
