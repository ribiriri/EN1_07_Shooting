using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // Start is called before the first frame update

    //�e�̃X�s�[�h
    public float speed = 5;
    //���R���ł܂ł̃^�C�}�[
    public float time = 10;
    //�i�s����
    protected Vector3 forward = new Vector3(1, 1, 1);

    //�ł��o���Ƃ��̊p�x
    protected Quaternion forwardAxis = Quaternion.identity;

    //Rigidbody�p�ϐ�
    protected Rigidbody rb;
    //Enemy�p�ϐ�
    protected GameObject enemy;

    


    void Start()
    {
        //RigidBody�ϐ���������
        rb = this.GetComponent<Rigidbody>();

        //�������ɐi�s���������߂�
        if (enemy != null)
        {
            forward = enemy.transform.forward;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //�ړ��ʂ�i�s�����ɃX�s�[�h������������
        rb.velocity = forwardAxis * forward * speed;
        //�󒆂ɕ����Ȃ��悤�ɂ���
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        //���Ԑ����������玩�R���ł���
        time -= Time.deltaTime;

        if (time <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (/*other.gameObject.tag == "Player||"*/ other.gameObject.tag == "PlayerBody")
        {
            // other.gameObject.GetComponent<player>().PlayerDamage();
            other.gameObject.GetComponent<playerHit>().PlayerDamage();
        }

        //�������������I�u�W�F�N�g�̃^�O��PlayerBody��������
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "PlayerBody")
        {
            
            // other.gameObject.GetComponent<player>().PlayerDamage();
            //���������ł�����
            Destroy(this.gameObject);
        }
    }

    //�e��ł��o�����L�����N�^�[�̏���n���֐�
    public void setCharacterObject(GameObject character)
    {
        //�e��ł��o�����L�����N�^�[�̏����󂯎��
        this.enemy = character;
    }
    //�ł��o���p�x�����肷�邽�߂̊֐�
    public void SetForwardAxis(Quaternion axis)
    {
        //�ݒ肳�ꂽ�p�x���󂯎��
        this.forwardAxis = axis;
    }

}
