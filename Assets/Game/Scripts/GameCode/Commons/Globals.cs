using System;
using Game.PlayerSystem;
using UnityEngine;

namespace Commons
{
    public static class Globals
    {
        private static GameObject playerToSpawn;
        private static ViewPlayer localPlayer;
        private static Vector3 playerSpawnPoint;
        private static Vector3 opponentSpawnPoint;
        public static GameObject PlayerPrefab
        {
            get
            {
                return playerToSpawn;
            }
            set
            {
                playerToSpawn = value;
            }
        }

        public static ViewPlayer LocalPlayer
        {
            get
            {
                return localPlayer;
            }
            set
            {
                localPlayer = value;
            }
        }
    }
}
