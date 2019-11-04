using Commons;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.CameraSystem
{
    public class ControllerCamera : MonoBehaviour
    {
        
        private Vector3 cameraOffset;
        [SerializeField]
        private GameObject localPlayer;
        private void Awake()
        {
            cameraOffset = transform.localPosition;
            //localPlayer = Globals.LocalPlayer;
        }
        private void LateUpdate()
        {
            LookAtLocalPlayer();
            MoveToLocalPlayer();
        }

        private void MoveToLocalPlayer()
        {
            this.transform.position = localPlayer.transform.position + cameraOffset;
        }

        private void LookAtLocalPlayer()
        {
           // transform.LookAt(localPlayer.transform);
        }
    }
}