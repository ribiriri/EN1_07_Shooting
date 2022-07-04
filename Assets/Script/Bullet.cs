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
        //�e�̃��[���h���W���擾
        Vector3 pos = transform.position;

        //��ɂ܂������Ƃ�
        pos.z += 0.8f;

        //�e�̈ړ�
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        //��苗���i�񂾂����
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
