using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// health bar status for player
/// </summary>
/// 

public class HealthBar : MonoBehaviour
{
    //player start off with max health
    public Slider slider;
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    //health for user is set at the current state of health
    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
