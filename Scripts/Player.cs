using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{/// <summary>
/// urm, coding for player health and hit damage
/// </summary>
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    // game will start with this amount of health
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // if the player collides with danger he will lose health
    void Update()
    {
        
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
