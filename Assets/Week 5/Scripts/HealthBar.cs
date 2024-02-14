using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    private void Start()
    {

    }
    public void TakeDamage(float value)
    {
        slider.value -= value;
    }

    void SetHealth(float health)
    {
        slider.value = health;
        Debug.Log("message sent");
    }

}
