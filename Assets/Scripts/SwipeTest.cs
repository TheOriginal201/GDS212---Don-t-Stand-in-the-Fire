using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour
{
    public Swipe swipeControls;
    public Transform player;
    private Vector3 desiredPosition;
    
    private void Update()
    {
        if (swipeControls.SwipeLeft)
            desiredPosition += new Vector3(-5, 0, 0);
        if (swipeControls.SwipeRight)
            desiredPosition += new Vector3(5, 0, 0);
        if (swipeControls.SwipeUp)
            desiredPosition += new Vector3(0, 0, 5);
        if (swipeControls.SwipeDown)
            desiredPosition += new Vector3(0, 0, -5);

        player.transform.position = Vector3.MoveTowards(player.transform.position, desiredPosition, 8f * Time.deltaTime);
    }

}
