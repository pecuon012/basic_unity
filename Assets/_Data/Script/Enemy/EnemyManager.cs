using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    List<Enemy> enemies = new List<Enemy>(); // khai báo danh sách cho manager là lớp Cha là Enemy cho đối tượng enemies
    Enemy smallestEnemy; //tạo một khung trong ể điền vào component của unity 
    Enemy biggestEnemy;
    private void Awake() // gọi một lần và gọi trước Start
    {
        LoadEnemies();
    }
    private void Start()
    {
        LoadSmallestEnemy();
        LoadBiggestEnemy();
    }
    protected virtual void LoadBiggestEnemy()
    {
        Enemy firstEnemy = this.enemies[0]; // lấy đối tượng đầu tiên trong danh sách
        float biggestWeight = firstEnemy.GetMinWeight();
        foreach (Enemy enemy in enemies)
        {
            float enemyWeight = enemy.Getweight();
            if (biggestWeight < enemyWeight)
            {
                biggestWeight = enemyWeight;
                biggestEnemy = enemy;
            }
            Debug.Log(enemy.name + " Weight: " + enemy.Getweight());
        }

    }


    protected virtual void LoadSmallestEnemy() // duyệt danh sách đã có là enemies
    {
        Enemy firstEnemy = this.enemies[0]; // lấy đối tượng đầu tiên trong danh sách
        float smallestWeight = firstEnemy.GetMaxWeight();// lấy giá trị lớn nhất ban đầu để so sánh !!
        foreach (Enemy enemy in enemies)// duyệt trong danh sách enemies với biến đại diện cho lần đầu tiên chạy là enemy
        {
            float enemyWeight = enemy.Getweight();
            if (smallestWeight > enemyWeight)
            {
                smallestWeight = enemyWeight;
                smallestEnemy = enemy;// điền tên vào danh sách smallestEnemy
            }
            //Debug.Log(enemy.name);// name ở đây là name obj
            //Debug.Log(enemy.Getname()); // này là name dc override getname
            //Debug.Log(enemy.GetObjName() + " Weight: " + enemy.Getweight());
        }
    }
    //foreach mình hiểu là lặp theo số đối tượng !
    protected virtual void LoadEnemies() // cho lớp kế thừa thì được dùng
    {
        foreach (Transform childObj in transform) // nghĩa là nó sẽ Duyệt lấy thông tin tất cả các đối tượng trong obj cha
        {
            //Debug.Log(childObj.name);
            Enemy enemy = childObj.GetComponent<Enemy>(); // lôi tất cả con cháu của Enemy vào obj enemy ( k hẳn là enemy )
            if (enemy == null) continue;
            this.enemies.Add(enemy); // enemies là biến của danh sách thêm danh sách vào EnemyManager tại debug Unity

        }

    }
}
