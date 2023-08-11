using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour
{
    public float stamina;
    float maxStamina;

    public Slider StaminaBar;
    public float dValue;

    void Start()
    {
        maxStamina = stamina;
        StaminaBar.maxValue = maxStamina;
    }

    void Update()
    {
       decrease();
       StaminaBar.value = stamina; 
    }

    private void decrease()
    {
        if(stamina != 0)
            stamina -= dValue * Time.deltaTime;
    }

    private void increase()
    {
        stamina += dValue * Time.deltaTime;
    }
}
