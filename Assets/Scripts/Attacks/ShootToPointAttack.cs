using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToPointAttack : Attack
{
    public Transform projectileSpawnPoint;
    public GameObject projecileEffects; //NOT THE ATTACK, projtile before the attack
    public GameObject attackPrefab;
    public float timeToReachPoint;

    public float timeToAttack;


    public override void DoAttack(GridPoint point)
    {
        StartCoroutine(AttackSequence(point));
    }

    IEnumerator AttackSequence(GridPoint point)
    {
        point.ShowAttack();
        yield return new WaitForSeconds(timeToAttack);

        Vector3 spawnPoint = projectileSpawnPoint.position;
        GameObject projectile = Instantiate(projecileEffects, spawnPoint, Quaternion.LookRotation(point.GetPosition() - spawnPoint));
        float time = 0f;
        while (time < 1f)
        {
            time += Time.deltaTime / timeToReachPoint;
            projectile.transform.position = Vector3.Lerp(spawnPoint, point.GetPosition(), time);
            yield return null;
        }
        Instantiate(attackPrefab, point.GetPosition(), Quaternion.identity);
        point.ShowSafe();
    }
}
