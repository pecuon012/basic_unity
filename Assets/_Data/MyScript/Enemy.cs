using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    int hp = 20;
    float hpc = 10f;
    int moment = 55;
    string enemyname = "alo";
    bool isDead = true;
    bool isBoss = true;

    protected abstract string Getname();
   
    float Currenthp()
    {
        return this.hpc;
    }
    int getWeight()
    {
        return this.hp;
    }
    bool IsBoss()
    {
        return this.isBoss;
    }
    
    public void Moving()
    {
        string logmessage = this.Getname() + " is coming";
        Debug.Log(logmessage);
    }         
}
