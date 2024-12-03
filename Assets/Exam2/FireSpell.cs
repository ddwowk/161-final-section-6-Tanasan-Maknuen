using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    public override void Cast()
    {
        Debug.Log("Casting Giant Fire ball!!!");
    }
    public override void Start()
    {
        base.Start();
        Cast(target);
        Cast(target,power);
    }
}
