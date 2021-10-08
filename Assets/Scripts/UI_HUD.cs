using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_HUD : MonoBehaviour
{
    public Image playerHealthBarFG;
    public Image bossHealthBarFG;
    public static UI_HUD Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public void UpdatePlayerHealth(float currentHealth, float maxHealth)
    {
        playerHealthBarFG.fillAmount = currentHealth / maxHealth;
        //bossHealthBarFG.fillAmount = currentHealth / maxHealth;
    }

    public void UpdateBossHealth(float currentHealth, float maxHealth)
    {
        //playerHealthBarFG.fillAmount = currentHealth / maxHealth;
        bossHealthBarFG.fillAmount = currentHealth / maxHealth;
    }

    public void DisablePlayerHealthBar()
    {
        playerHealthBarFG.transform.parent.gameObject.SetActive(false);
        //bossHealthBarFG.transform.parent.gameObject.SetActive(false);
    }

    public void DisableBossHealthBar()
    {
        //playerHealthBarFG.transform.parent.gameObject.SetActive(false);
        bossHealthBarFG.transform.parent.gameObject.SetActive(false);
    }
}
