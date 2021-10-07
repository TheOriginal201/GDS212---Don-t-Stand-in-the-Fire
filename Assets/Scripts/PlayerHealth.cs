using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 30;
    private float currentHealth = 0;

    private void Start()
    {
        currentHealth = maxHealth;
        UI_HUD.Instance.UpdatePlayerHealth(currentHealth, maxHealth);
    }

    public bool OnDamage(float amount)
    {
        if(currentHealth > 0)
        {
            currentHealth -= amount;
            if(currentHealth <= 0)
            {
                currentHealth = 0;
                OnDeath();
            }

            UI_HUD.Instance.UpdatePlayerHealth(currentHealth, maxHealth);
            return true;
        }
        return false;
    }

    public void OnDeath()
    {
        UI_HUD.Instance.DisablePlayerHealthBar();
        Debug.Log(gameObject.name + " died.");
    }
}
