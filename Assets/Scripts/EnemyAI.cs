using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
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
        while (currentAttack < attackTimeline.Length)
        {
            AttackEvent attackEvent = attackTimeline[currentAttack];
            attackEvent.attackComponent.DoAttack(GridMManager.current.GetPosition(attackEvent.gridPosition));
            yield return new WaitForSeconds(attackEvent.timeToNextAttack);
            currentAttack++;
        }
    }
}
