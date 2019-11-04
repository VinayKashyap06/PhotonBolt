using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Bolt.EntityBehaviour<INewPlayerState>
{
    [Range(0,5)]
    public float speed=3f;

    [SerializeField]
    private Animator playerAnimator;
    //attached function of entity behaviour called
    public override void Attached()
    {
        //setting state's transform to this component's transform
        state.SetTransforms(state.NewPlayerTransform, transform);
        state.SetAnimator(playerAnimator);
    }

    //update for local controller
    public override void SimulateOwner()
    {
        Vector3 mov = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
        {
            mov.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            mov.x += 1;
        }
        if (Input.GetKey(KeyCode.W))
        {
            mov.z += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            mov.z -= 1;
        }

        if (mov!=Vector3.zero)
        {
            transform.position += mov * speed * BoltNetwork.FrameDeltaTime; //stands for deltatime
            state.isIdle = false;
        }
        else
        {
            state.isIdle = true;
        }
    }

    private void FixedUpdate()
    {        
        if (state.isIdle)
            state.Animator.Play("Idle");
        else
            state.Animator.Play("ChangeColor");
    }
}