using UnityEngine;
using System.Collections;

public class PlayerEvents : Bolt.EntityBehaviour<INewPlayerState>
{    
    public override void Attached()
    {
        var evnt = NewPlayerJoinedEvent.Create();
        evnt.Message = "Welcome!";
        evnt.Send();
    }


}
