using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PoisionSpell : Spell
{
    [SerializeField] string debuff;
    public override void Cast()
    {
        Debug.Log("Casting of rain poision!!!");
    }
    public void Cast(string targetName, int power, string debuff)
    {
        Debug.Log($"Casting a spell on a: {targetName} with skill power level {power} and {targetName} get {debuff}  !!!!!");
    }
    public override void Start()
    {
        base.Start();
        Cast(target);
        Cast(target, power);
        Cast(target, power, debuff);
    }
}
