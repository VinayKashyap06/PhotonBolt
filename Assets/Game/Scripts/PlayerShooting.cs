using UnityEngine;
using Bolt;
using System.Collections;

public class PlayerShooting : EntityBehaviour<INewPlayerState>
{
    public Rigidbody bulletPrefab;
    public GameObject muzzle;
    [Range(0,5)]
    public float speed=5f;

    public override void Attached()
    {
        state.OnShootTrigger = Shoot;
    }
    private void Shoot()
    {
        Rigidbody bulletClone = GameObject.Instantiate(bulletPrefab.gameObject,muzzle.transform.position,muzzle.transform.rotation).GetComponent<Rigidbody>();
        bulletClone.velocity = muzzle.transform.forward *speed;
    }

    public override void SimulateOwner()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //call trigger(condition)
            state.ShootTrigger();
        }
    }
}
