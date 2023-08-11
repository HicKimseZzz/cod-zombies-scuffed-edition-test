using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeDmg : MonoBehaviour
{
    public float health = 100;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TakeDamage(float gDamage)
    {
        health -= gDamage;
        if (0 >= health){
            Destroy(gameObject);
        }
    }
}
