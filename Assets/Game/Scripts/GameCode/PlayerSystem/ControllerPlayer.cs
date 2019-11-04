using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.PlayerSystem
{
    
    public class ControllerPlayer
    {
        private Vector3 spawnPoint;
        public ControllerPlayer(Vector3 spawnPoint)
        {
            this.spawnPoint = spawnPoint;
            SpawnPlayer();
        }

        private void SpawnPlayer()
        {
            
        }
    }
}