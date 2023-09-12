using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public Slider slider;

    private void Update()
    {
        slider.value = Mathf.MoveTowards(slider.value, 100.0f, 0.15f);
    }
}
