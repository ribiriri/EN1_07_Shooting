using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int timer;
    private int timerMax;
    // Start is called before the first frame update
    void Start()
    {
        timer = 60;
        timerMax = timer;
    }


    // Update is called once per frame
    void Update()
    {
        //弾のワールド座標を取得
        Vector3 pos = transform.position;

        //上にまっすぐとぶ
        pos.z += 0.8f;

        //弾の移動
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        //一定距離進んだら消滅
        if (timer <= 0)
        {
            Destroy(this.gameObject);
        }

        timer--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<Enemy>().Damage();
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "BossEnemy")
        {
            other.gameObject.GetComponent<BossEnemy>().Damage();
            Destroy(this.gameObject);
        }
    }

}
