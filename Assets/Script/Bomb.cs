using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    // Start is called before the first frame update

    //����������p�[�e�B�N���̃v���n�u
    public GameObject particle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�L�[�{�[�h��B�L�[�������ꂽ��
        if (Input.GetKeyDown(KeyCode.B))
        {
            //�^�O�������I�u�W�F�N�g��S�Ď擾����
            GameObject[] enemyBulletObjects =
                    GameObject.FindGameObjectsWithTag("EnemyBullet");

            //��ŏ����������ׂẴI�u�W�F�N�g�����ł�����
            for (int i = 0; i < enemyBulletObjects.Length; i++)
            {
                Destroy(enemyBulletObjects[i]);
            }
            //�p�[�e�B�N�����������I�u�W�F�N�g�𐶐�����
            Instantiate(particle, Vector3.zero, Quaternion.identity);
        
        }
    }
}
