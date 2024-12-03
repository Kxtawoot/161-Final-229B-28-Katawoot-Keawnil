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
        
    }
    public abstract float CalculateFoodRequirement()
    {

    }
    public void MakeSound()
    {
        
    }
    public void DisplayName()
    {
        
    }


}
