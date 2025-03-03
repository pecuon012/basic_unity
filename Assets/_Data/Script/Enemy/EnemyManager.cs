using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    List<Enemy> enemies = new List<Enemy>(); // khai báo danh sách cho manager là lớp Cha là Enemy cho đối tượng enemies
    private void Awake() // gọi một lần 
    {
        LoadEnemies();
    }
    protected virtual void LoadEnemies() // cho lớp kế thừa thì được dùng
    {
        foreach (Transform childObj in transform) // nghĩa là nó sẽ duyệt lấy thông tin tất cả các đối tượng trong obj cha
        {
            Debug.Log(childObj.name);
            Enemy enemy = childObj.GetComponent<Enemy>(); // lôi tất cả con cháu của Enemy vào obj enemy ( k hẳn là enemy )
            if (enemy == null) continue;
            this.enemies.Add(enemy); // enemies là biến của danh sách thêm danh sách vào EnemyManager tại debug Unity
            
        }

    }
}
