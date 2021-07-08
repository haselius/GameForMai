using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void MaxHealth(int life)
    {
        slider.maxValue = life;
        slider.value = life;
    }

    public void CurrentHealth(int life) 
    {
        slider.value = life;
    }
}
