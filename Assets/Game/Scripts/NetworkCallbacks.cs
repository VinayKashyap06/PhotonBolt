using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[BoltGlobalBehaviour]
public class NetworkCallbacks : Bolt.GlobalEventListener
{
    //after scene loading is done
    
    public override void SceneLoadLocalDone(string scene)
    {
        Vector3 spawnPoint = new Vector3(Random.Range(-8,8), 0, Random.Range(-8,8));
        //instanitae over Bolt network
        //give random spawn point
        //only works with assigned entities and prefabs
        BoltNetwork.Instantiate(BoltPrefabs.NewPlayer,spawnPoint,Quaternion.identity);

    }
}
