using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPrefabMang : MonoBehaviour
{

    public float timeUntilDeath = 1f;

    void Start()
    {
        //Destroy(gameObject, timeUntilDeath);
        StartCoroutine(SelfDescruct());
    }

    IEnumerator SelfDescruct()
    {
        yield return new WaitForSeconds(timeUntilDeath);
        Destroy(gameObject);
    }
}
