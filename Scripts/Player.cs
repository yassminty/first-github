using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{/// <summary>
/// urm, coding for player health and hit damage &collecting items with dnager plates
/// </summary>
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    public int currentScore = 5;
    public int currentNanners = 0;

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

    //to incrcease player score
    public void IncreaseScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;
        Debug.Log(currentScore);
    }

    //total bananas congrats message
    public void TotalNanners(int nannersToAdd)
    {
        currentNanners += nannersToAdd;
        Debug.Log(currentNanners);
    }

}
