using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    int currenthp = 215;
    float hpc = 10f;
    int moment = 55;
    string enemyname = "enemy";
    bool isDead = true;
    bool isBoss = true;

    public abstract string Getname(); // abstract luôn ?? trên ??u

    float Getweight()
    {
        return this.hpc;
    }
    public virtual int GetCurrenthp() //virtual khi hàm có body
    {
        return this.currenthp;
    }
    public virtual void Sethp(int newhp)
    {
        currenthp = newhp;
    }
    bool IsBoss()
    {
        return this.isBoss;
    }
    public virtual bool isdead()
    {
        if (currenthp > 0) isDead = false;
        else isDead = true;
        return isDead;
    }

    public void Moving()
    {
        string logmessage = this.Getname() + " is coming";
        Debug.Log(logmessage);
    }
}
