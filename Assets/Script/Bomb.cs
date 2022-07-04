using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    // Start is called before the first frame update

    //発生させるパーティクルのプレハブ
    public GameObject particle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //キーボードのBキーが押されたら
        if (Input.GetKeyDown(KeyCode.B))
        {
            //タグが同じオブジェクトを全て取得する
            GameObject[] enemyBulletObjects =
                    GameObject.FindGameObjectsWithTag("EnemyBullet");

            //上で所得したすべてのオブジェクトを消滅させる
            for (int i = 0; i < enemyBulletObjects.Length; i++)
            {
                Destroy(enemyBulletObjects[i]);
            }
            //パーティクルを持ったオブジェクトを生成する
            Instantiate(particle, Vector3.zero, Quaternion.identity);
        
        }
    }
}
