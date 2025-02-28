using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Enemy
{
    string name = "sinhvat";
    protected override string Getname()
    {
        return this.name;
    }
}
