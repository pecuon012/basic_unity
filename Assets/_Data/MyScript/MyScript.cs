using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using UnityEditor.MemoryProfiler;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    void FixedUpdate()
    {
        //TestClass();
        //TestOperator();
        TestIsDead();
    }
    void TestIsDead()
        
    {
        Zombie zombie = new Zombie();
        Wolf wofl = new Wolf();
        zombie.Sethp(-50);
        //string logmessage = zombie.Getname() + wofl.isdead();
        string logmessage = zombie.Getname() + ": " + zombie.GetCurrenthp() + " " + zombie.isdead();
        Debug.Log(logmessage);
    }
    void TestOperator()
    {
        int variable = 100;
        int cong = 200 + 100;
        int tru = 200 - 100;
        int nhan = 200 * 100;
        int chia = 200 / 100;
        Debug.Log("variablecong:" + cong);
        Debug.Log("variabletru:" + tru);
        Debug.Log("variablenhan:" + nhan);
        Debug.Log("variablechia:" + chia);
    }
    public void TestClass()
    {
        Zombie zombie = new Zombie();
        Ghost ghost = new Ghost();
        Wolf wofl = new Wolf();
        zombie.Moving();
        ghost.Moving();
        wofl.Moving();

    }
}

