using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBoss : MonoBehaviour
{
    public Animator anim;
    public GameObject boss;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BossHealth>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
