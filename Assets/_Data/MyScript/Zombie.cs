using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy
{
    string name = "meow";
    protected override string Getname()
    {
        return this.name;
    }
}
