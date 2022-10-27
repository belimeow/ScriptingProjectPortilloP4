using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatement : MonoBehaviour
{
    float coffeeTemperture = 85.0f;
    float hotLimitTemperture = 70.0f;
    float coldLimitTemperture = 40.0f;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TempertureTest();

        coffeeTemperture -= Time.deltaTime * 5f;
    }


    void TempertureTest ()
    {
        // if the coffee's temperture is greater than the hottest drinking temeprture 
        if(coffeeTemperture > hotLimitTemperture)
        {
            // ... do this.
            print("Coffee is too cold.");
        }
        //If it isn't, but the coffee temperture is less than the coldest drinking temperture...
        else if(coffeeTemperture < coldLimitTemperture)
        {
            // ... do this.
            print("coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }
    }
}
