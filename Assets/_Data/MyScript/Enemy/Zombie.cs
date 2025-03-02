using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy
{
    string name = "Zombie";
    public override string Getname()
    {
        return this.name;
    }
}
