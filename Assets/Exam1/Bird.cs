using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    [SerializeField] private float dailyFoodConsumption;
    [SerializeField] private float weight;

    public override float CalculateFoodRequirement()
    {
        return (dailyFoodConsumption) * weight * 7;
    }
    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"{animalName} Say Jib Jib");
    }
    public override void DisplayName()
    {
        Init("Bird");
        base.DisplayName();
        Debug.Log($"{animalName} eat {dailyFoodConsumption} kg of food daily and weight {weight} kg");
        Debug.Log($"{animalName} weekly food requirement: {CalculateFoodRequirement()} kg.");
    }
}
