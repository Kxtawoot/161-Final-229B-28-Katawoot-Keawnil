using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public string animalName = "Dog";
    private int activityLevel = 3;
    private float dailyFoodCosumtion = 10;

    public override float CalculateFoodRequirement(float Calculate)
    {
        Calculate = (dailyFoodCosumtion)* (activityLevel)* 7;
    }

public void MakeSound()
    {
        Debug.Log($"{animalName} make a sound");
    }
}
