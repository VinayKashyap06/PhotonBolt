using UnityEngine;
using System.Collections;

public class PlayerHealth : Bolt.EntityBehaviour<INewPlayerState>
{
    [Range(1,10)]
    public int localHealth =5 ;

    public override void Attached()
    {
        state.Health = localHealth;
        // add callback similar to listeners in Unity buttons
        state.AddCallback(nameof(state.Health),HealthCallback);                
    }

    //callback to be called
    private void HealthCallback()
    {
        localHealth = state.Health;        
        if (localHealth<=0)
        {
            //to destroy over network
           BoltNetwork.Destroy(this.gameObject);
        }

    }
    public override void SimulateOwner()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // state.Health -= 1;
        }        
    }
}
