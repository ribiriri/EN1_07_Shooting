using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GManager : MonoBehaviour
{
    // Start is called before the first frame update
    //�G�̐��𐔂���
    private GameObject[] enemy;
    private GameObject[] bossEnemy;
    //�Ղꂢ��[
    private GameObject player;

    //�p�l����o�^����
    public GameObject clearPanel;
    public GameObject gameoverPanel;
    public GameObject panelButton;

    private bool gameOverFlag;
    private bool clearFlag;

    public int playerDamageCount;

    //�v���C���[���G
    private bool mutekiTimerFlag;
    private int mutekiTimer;
    private int mutekiTime;

    //
    public Text textHP;
    private int playerHP;


    void Start()
    {
        playerHP = 10;
        clearFlag = false;
        gameOverFlag = false;

        playerDamageCount = 0;

        //�p�l�����B��
        clearPanel.SetActive(false);
        gameoverPanel.SetActive(false);
        panelButton.SetActive(false);

        //���G�����܁[
        mutekiTimerFlag = false;
        mutekiTimer = 60;
        mutekiTime = mutekiTimer;
    }

    // Update is called once per frame
    void Update()
    {
        //�V�[���ɑ��݂��Ă���Enemy�^�O�������Ă���I�u�W�F�N�g
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        bossEnemy = GameObject.FindGameObjectsWithTag("BossEnemy");
        //�V�[���ɑ��݂��Ă���Player�^�O�������Ă���I�u�W�F�N�g
        player = GameObject.FindGameObjectWithTag("Player");

        //�V�[����1�C��Enemy�����Ȃ��Ȃ�����
        if (enemy.Length == 0 && bossEnemy.LongLength == 0)
        {
            if (!gameOverFlag)
            {
                clearFlag = true;
                //�p�l����\��������
                clearPanel.SetActive(true);
                panelButton.SetActive(true);
            }
        }

        //�V�[���Ƀv���C���[�����Ȃ��Ȃ�����
        if (!player)
        {
            if (!clearFlag)
            {
                gameOverFlag = true;
                ////�p�l����\��������
                gameoverPanel.SetActive(true);
                panelButton.SetActive(true);
            }
        }

        if (mutekiTimerFlag)
        {
            mutekiTime--;
            if (mutekiTime < 0)
            {
                mutekiTime = mutekiTimer;
                mutekiTimerFlag = false;
            }

        }

        PlayerHPcount();
    }

    public int PlayerCheck()
    {
        return playerDamageCount;
    }
    public void PlayerCheckCount()
    {
        if (!mutekiTimerFlag)
        {
            if (playerDamageCount < playerHP) playerDamageCount++;
            mutekiTimerFlag = true;
        }
    }

    public void PlayerHPcount()
    {
        textHP.text = "HP:" + (playerHP - playerDamageCount);
    
    }
}
