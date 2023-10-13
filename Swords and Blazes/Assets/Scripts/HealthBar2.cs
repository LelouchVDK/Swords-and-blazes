using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar2 : MonoBehaviour
{
    public Slider slider2;
    public Gradient gradient2;
    public Image fill2;

    public void SetMaxHealth(int health)
    {
        slider2.maxValue = health;
        slider2.value = health;

        fill2.color = gradient2.Evaluate(1f);

    }

    public void SetHealth(int health)
    {
        slider2.value = health;

        fill2.color = gradient2.Evaluate(slider2.normalizedValue);
    }
}
