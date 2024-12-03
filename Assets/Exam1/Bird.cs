using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    public string animalName = "Bird";
    private float dailyFoodConsumption = 1;
    private float weight = 1;

    public override float CalculateFoodRequirement(float Calculate)
    {
        Calculate = (dailyFoodConsumption) * (weight) * 7;
    }

}
