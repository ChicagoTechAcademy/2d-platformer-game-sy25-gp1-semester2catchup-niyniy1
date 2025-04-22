using System;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour
{
    
    [SerializeField]private int playerHealth = 3;
    [SerializeField]private TextMeshProUGUI healthText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        healthText.text = "Health: " + playerHealth.ToString();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
