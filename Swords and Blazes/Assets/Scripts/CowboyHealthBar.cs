using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CowboyHealthBar : MonoBehaviour
{

    public Slider cowboySlider;
    public Gradient cowboyGradient;
    public Image cowboyFill;

    public void SetMaxHealth(int health)
    {
        cowboySlider.maxValue = health;
        cowboySlider.value = health;

        cowboyFill.color = cowboyGradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        cowboySlider.value = health;

        cowboyFill.color = cowboyGradient.Evaluate(cowboySlider.normalizedValue);
    }
   
}
