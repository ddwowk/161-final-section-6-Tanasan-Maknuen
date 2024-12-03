using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class IceSpell : Spell
{
    public override void Cast()
    {
        Debug.Log("Casting Big Ice Lance!!!");
    }
    public override void Start()
    {
        base.Start();
        Cast(target);
        Cast(target, power);
    }
}
