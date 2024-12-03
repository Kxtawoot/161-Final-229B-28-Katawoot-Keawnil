using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;
    public string AnimalName
    {
        get 
        {
            return animalName;
        }
        set 
        {
            animalName = value;
        }

    }
    public void Init()
    {
        Animal.MakeSound();
        Animal.DisplayName();
        Animal.CalculateFoodRequirement();
    }
    public abstract float CalculateFoodRequirement(float Calculate)
    {
        Dog.Calculate;
        Bird.Calculate;
    }
    public void MakeSound()
    {
        Debug.Log($"{Dog.animalName} Bark : Woof Woof");
        Debug.Log($"{Bird.animalName} Chirps : Tweet Tweet");
    }
    public void DisplayName()
    {
        Debug.Log($"This is a {Bird.animalName}");
        Debug.Log($"This is a {Dog.animalName}");
    }





}
