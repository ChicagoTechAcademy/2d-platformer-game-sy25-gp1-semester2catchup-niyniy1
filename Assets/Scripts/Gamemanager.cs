using System;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour
{

    [SerializeField] private int playerHealth = 3;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private PlayerController player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateHealthText();
    }

    public void loseHealth(int healthToLose)
    {
        playerHealth = playerHealth - healthToLose;
        UpdateHealthText();
        HealthCheck();
    }


    public void gainHealth(int healthToGain)
    {
        playerHealth = playerHealth + healthToGain;
        UpdateHealthText();
    }
    private void UpdateHealthText()
    {
        healthText.text = "Health: " + playerHealth.ToString();
    }

    private void HealthCheck()
    {
        if (playerHealth <= 0)
        {
            player.PlayerDeath();
        }
    }
}


    



