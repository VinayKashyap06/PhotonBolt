using Game.PlayerSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Commons
{
    public class NetworkCallbacksHandler : Bolt.GlobalEventListener
    {
        public override void SceneLoadLocalDone(string scene)
        {
            //Instantiate over network
            GameObject player = BoltNetwork.Instantiate(BoltPrefabs.PlayerCharacter);
            Globals.LocalPlayer = player.GetComponent<ViewPlayer>();
        }
    }
}