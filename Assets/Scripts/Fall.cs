using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public SwipeTest swipe;
    public Rigidbody rb;

    private bool previousIsMoving = false;
    private void Update()
    {
        if(swipe.isMoving != previousIsMoving)
        {
            if (swipe.isMoving == false)
            {
                RaycastHit[] hits = Physics.RaycastAll(transform.position, Vector3.down, LayerMask.NameToLayer("GridPoint"));

                if (hits.Length == 0)
                {
                    swipe.enabled = false;
                    rb.isKinematic = false;
                }
            }
            
            previousIsMoving = swipe.isMoving;

        }
    }

}
