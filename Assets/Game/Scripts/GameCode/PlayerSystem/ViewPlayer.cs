using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bolt;

namespace Game.PlayerSystem
{
    public class ViewPlayer : EntityBehaviour<IPlayerCharacterState>
    {
        public override void Attached()
        {
            state.SetTransforms(state.Transform,transform);
        }
        private void FixedUpdate()
        {
            
            float y = Input.GetAxis("Vertical");
            float x = Input.GetAxis("Horizontal");
            if (y!=0)
            {
                this.transform.position += new Vector3(0,0,y);
            }
            else if (x!=0)
            {
                this.transform.position += new Vector3(x, 0, 0);
            }          
        }       
    }
}