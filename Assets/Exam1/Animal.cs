using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;

    public void Init(string name)
    {
        animalName = name;
    }
    public abstract float CalculateFoodRequirement();
    public virtual void MakeSound()
    {
        Debug.Log("Animal Make Sound");
    }
    public virtual void DisplayName()
    {
        Debug.Log($"This is {animalName}");
        MakeSound();
    }
    public void Start()
    {
        DisplayName();
    }
}
