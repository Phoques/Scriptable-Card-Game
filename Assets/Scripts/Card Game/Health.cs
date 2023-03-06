using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Variable;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth = 100;
    public int minHealth = 0;

    CardBehaviour cardBehaviour;
    
  
    
    

    public Text healthText;
    private void Start()
    {
        health = maxHealth;
    }

    private void Update()
    {
        healthText.text = health.ToString();
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
    }




}
