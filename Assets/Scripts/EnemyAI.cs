using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Animator anim;

    [Serializable]
    public struct AttackEvent
    {
        public Attack attackComponent;
        public Vector2Int gridPosition;
        public float timeToNextAttack;
    }

    public AttackEvent[] attackTimeline = new AttackEvent[0];


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartAttacking()
    {
        StartCoroutine(TimelineSequence());
    }

    private IEnumerator TimelineSequence()
    {
        int currentAttack = 0;
        while (true)
        {
            AttackEvent attackEvent = attackTimeline[currentAttack];
            anim.SetTrigger(attackEvent.attackComponent.animationTrigger);
            attackEvent.attackComponent.DoAttack(GridMManager.current.GetGridPoint(attackEvent.gridPosition));
            yield return new WaitForSeconds(attackEvent.timeToNextAttack);
            currentAttack++;

            currentAttack %= attackTimeline.Length;
        }
    }
}
