using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    [SerializeField]private float dailyFoodConsumption;
    [SerializeField]private int actovityLevel;

    public override float CalculateFoodRequirement()
    {
        return (dailyFoodConsumption) * actovityLevel * 7;
    }
    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log($"{animalName} is Barking");
    }
    public override void DisplayName()
    {
        Init("Dog");
        base.DisplayName();
        Debug.Log($"{animalName} eat {dailyFoodConsumption} kg of food daily with action active level {actovityLevel}");
        Debug.Log($"{animalName} weekly food requirement: {CalculateFoodRequirement()} kg.");
    }
}
