using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public float maxHealth = 100;
    private float currentHealth = 0;

    public Animator anim;

    private void Start()
    {
        currentHealth = maxHealth;
        UI_HUD.Instance.UpdateBossHealth(currentHealth, maxHealth);
    }

    public bool OnDamage(float amount)
    {
        if (currentHealth > 0)
        {
            currentHealth -= amount;
            if (currentHealth <= 0)
            {
                currentHealth = 0;
                OnDeath();
            }

            UI_HUD.Instance.UpdateBossHealth(currentHealth, maxHealth);
            return true;
        }
        return false;
    }

    public void OnDeath()
    {
        UI_HUD.Instance.DisableBossHealthBar();
        Debug.Log(gameObject.name + " died.");

        anim.SetTrigger("Death");
    }
}
