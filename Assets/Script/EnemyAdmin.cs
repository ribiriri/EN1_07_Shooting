using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAdmin : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] enemy;
    private GameObject[] bossEnemy;

    private int enemyCount;

    void Start()
    {
        enemyCount = 0;

        //シーンに存在しているEnemyタグを持っているオブジェクト
        enemy[0] = GameObject.FindGameObjectWithTag("Enemy1");
        enemy[1] = GameObject.FindGameObjectWithTag("Enemy2");
        enemy[2] = GameObject.FindGameObjectWithTag("Enemy3");
        enemy[3] = GameObject.FindGameObjectWithTag("Enemy4");
        enemy[4] = GameObject.FindGameObjectWithTag("Enemy5");
        enemy[5] = GameObject.FindGameObjectWithTag("Enemy6");
        enemy[6] = GameObject.FindGameObjectWithTag("Enemy7");
        bossEnemy = GameObject.FindGameObjectsWithTag("BossEnemy");

        enemy[1].SetActive(false);
        enemy[2].SetActive(false);
        enemy[3].SetActive(false);
        enemy[4].SetActive(false);
        enemy[5].SetActive(false);
        enemy[6].SetActive(false);

        bossEnemy[0].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
   

        //if (!enemy[0]) enemy[1].SetActive(true);
        //if (!enemy[1]) enemy[2].SetActive(true);

        //if (!enemy[2]) enemy[3].SetActive(true);
        //if (!enemy[2]) enemy[4].SetActive(true);

        //if (!enemy[3] && !enemy[4])
        //{
        //    enemy[4].SetActive(true);
        //    enemy[5].SetActive(true);
        //    enemy[6].SetActive(true);
        //}
        //if (!enemy[4] && !enemy[5] && !enemy[6]) bossEnemy[0].SetActive(true);




    }
}
