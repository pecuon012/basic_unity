using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    int currenthp = 215;
    float weight = 10f;
    float minWeight = 1f;
    float maxWeight = 20f;
    //string enemyname = "enemy";
    bool isDead = true;
    bool isBoss = true;
    private void FixedUpdate()
    {
        //TestClass();
        //Moving();
    }
    public abstract string Getname(); // abstract luôn trên cùng

    public virtual string GetObjName()
    {
        return transform.name;
        //return gameObject.name; nh? nhau !
        // có th? eneny.name con m? luôn ?i !
    }
    private void TestClass()
    {
        Sethp(-50);
        //string logmessage = zombie.Getname() + wofl.isdead();
        string logmessage = Getname() + ": " + GetCurrenthp() + " " + isdead();
        Debug.Log(logmessage);
    }
    private void OnEnable()
    {
        InitData();
    }
    public virtual float GetMinWeight()
    {
        return minWeight;
    }
    public virtual float GetMaxWeight()
    {
        return maxWeight;
    }
    public virtual float Getweight()
    {
        return this.weight;
    }
    protected virtual void InitData()
    {
        weight = GetRandomWeight();
    }
    public virtual float GetRandomWeight() // hàm tr? giá tr? 
    {
        return Random.Range(minWeight, maxWeight);
    }
    public virtual int GetCurrenthp() //virtual khi hàm có body
    {
        return this.currenthp;
    }
    public virtual void Sethp(int newhp)
    {
        currenthp = newhp;
    }
    public virtual bool IsBoss()
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
