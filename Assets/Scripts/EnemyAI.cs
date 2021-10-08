using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Animator anim;

    bool alive = true;

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

    public void StopAttacking()
    {
        StopCoroutine(TimelineSequence());
        alive = false;
    }

    private IEnumerator TimelineSequence()
    {
        int currentAttack = 0;
        while (true)
        {
            AttackEvent attackEvent = attackTimeline[currentAttack];
            attackEvent.attackComponent.DoAttack(GridMManager.current.GetGridPoint(attackEvent.gridPosition));
            anim.SetTrigger(attackEvent.attackComponent.animationTrigger);
            yield return new WaitForSeconds(attackEvent.timeToNextAttack);
            currentAttack++;

            currentAttack %= attackTimeline.Length;

            if (alive == false) break;
        }
    }
}
