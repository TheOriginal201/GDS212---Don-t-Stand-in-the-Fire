using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int damage;
    public SwipeTest moving;
    public BossHealth bossHealth;
    
    public void Attack()
    {
        if(moving.isMoving == false)
        {
            bossHealth.OnDamage(damage);
        }
    }
}
