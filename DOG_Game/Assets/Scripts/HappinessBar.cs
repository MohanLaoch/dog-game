using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappinessBar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;

    public Image fill;

    // Sets slider to max happiness
    public void SetMaxHappiness(int happiness)
    {
        slider.maxValue = happiness;
        slider.value = happiness/2;

        fill.color = gradient.Evaluate(.5f);
    }

    // Sets slider to current happiness
    public void SetHappiness(int happiness)
    {
        slider.value = happiness;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

}