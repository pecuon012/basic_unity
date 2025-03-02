using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Enemy
{
    string name = "Ghost";
    public override string Getname()
    {
        return this.name;
    }
}
