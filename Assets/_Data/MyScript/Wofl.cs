using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : Enemy
{
    string name = "hello";
    protected override string Getname()
    {
        return this.name;
    }
}
