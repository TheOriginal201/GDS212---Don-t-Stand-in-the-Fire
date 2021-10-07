using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest1 : MonoBehaviour
{
    public Swipe1 swipeControls;
    public Transform player;
    private Vector3 desiredPosition;
    
    private void Update()
    {
        if (swipeControls.SwipeLeft)
            desiredPosition += new Vector3(-1.25f, 0, 0);
        if (swipeControls.SwipeRight)
            desiredPosition += new Vector3(1.25f, 0, 0);
        if (swipeControls.SwipeUp)
            desiredPosition += new Vector3(0, 0, 1.25f);
        if (swipeControls.SwipeDown)
            desiredPosition += new Vector3(0, 0, -1.25f);

        player.transform.position = Vector3.MoveTowards(player.transform.position, desiredPosition, 8f * Time.deltaTime);
    }

}
