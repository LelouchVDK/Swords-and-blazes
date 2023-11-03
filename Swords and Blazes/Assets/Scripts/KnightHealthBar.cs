using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnightHealthBar : MonoBehaviour
{
    public Slider knightSlider;
    public Gradient knightGradient;
    public Image knightFill;

    public void SetMaxHealth(int health)
    {
        knightSlider.maxValue = health;
        knightSlider.value = health;

        knightFill.color = knightGradient.Evaluate(1f);

    }

    public void SetHealth(int health)
    {
        knightSlider.value = health;

        knightFill.color = knightGradient.Evaluate(knightSlider.normalizedValue);
    }
}
