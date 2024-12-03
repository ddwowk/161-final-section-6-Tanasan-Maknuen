using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public string target;
    public int power;
    public virtual void Cast()
    {
        Debug.Log("Test Base Class");
        Debug.Log($"You Casting A Common Spell ;-;");
    }
    public void Cast(string targetName)
    {
        Debug.Log($"Casting a spell on a: {targetName}");
    }
    public void Cast(string targetName, int Power)
    {
        Debug.Log($"Casting a spell on a: {targetName} with skill power level {Power} !!!!!");
    }
    public virtual void Start()
    {
        Cast();
    }
}
