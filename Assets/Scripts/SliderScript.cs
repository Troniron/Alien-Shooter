using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField]
    private Slider Slider;
    [SerializeField]
    private Image fill;
    [SerializeField]
    private Gradient colour;

   public void maxhealth(int health)
    {
        Slider.maxValue = health;
      Slider.value = health;
        fill.color = colour.Evaluate(1f);

    }
    public void sliderhealth(int health)
    {
        Slider.value = health;
        fill.color = colour.Evaluate(Slider.normalizedValue);
    }
}
