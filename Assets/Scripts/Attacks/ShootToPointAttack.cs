using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToPointAttack : Attack
{
    public Transform projectileSpawnPoint;
    public GameObject projecileEffects; //NOT THE ATTACK, projtile before the attack
    public GameObject attackPrefab;
    public float timeToReachPoint;

    public override void DoAttack(Vector3 point)
    {
        StartCoroutine(AttackSequence(point));
    }

    IEnumerator AttackSequence(Vector3 point)
    {
        Vector3 spawnPoint = projectileSpawnPoint.position;
        GameObject projectile = Instantiate(projecileEffects, spawnPoint, Quaternion.LookRotation(point - spawnPoint));
        float time = 0f;
        while (time < 1f)
        {
            time += Time.deltaTime / timeToReachPoint;
            projectile.transform.position = Vector3.Lerp(spawnPoint, point, time);
            yield return null;
        }
        Instantiate(attackPrefab, point, Quaternion.identity);
    }
}
