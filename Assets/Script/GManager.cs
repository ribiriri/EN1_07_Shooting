using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GManager : MonoBehaviour
{
    // Start is called before the first frame update
    //敵の数を数える
    private GameObject[] enemy;
    private GameObject[] bossEnemy;
    //ぷれいやー
    private GameObject player;

    //パネルを登録する
    public GameObject clearPanel;
    public GameObject gameoverPanel;
    public GameObject panelButton;

    private bool gameOverFlag;
    private bool clearFlag;

    public int playerDamageCount;

    //プレイヤー無敵
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

        //パネルを隠す
        clearPanel.SetActive(false);
        gameoverPanel.SetActive(false);
        panelButton.SetActive(false);

        //無敵たいまー
        mutekiTimerFlag = false;
        mutekiTimer = 60;
        mutekiTime = mutekiTimer;
    }

    // Update is called once per frame
    void Update()
    {
        //シーンに存在しているEnemyタグを持っているオブジェクト
        enemy = GameObject.FindGameObjectsWithTag("Enemy");
        bossEnemy = GameObject.FindGameObjectsWithTag("BossEnemy");
        //シーンに存在しているPlayerタグを持っているオブジェクト
        player = GameObject.FindGameObjectWithTag("Player");

        //シーンに1匹もEnemyがいなくなったら
        if (enemy.Length == 0 && bossEnemy.LongLength == 0)
        {
            if (!gameOverFlag)
            {
                clearFlag = true;
                //パネルを表示させる
                clearPanel.SetActive(true);
                panelButton.SetActive(true);
            }
        }

        //シーンにプレイヤーがいなくなったら
        if (!player)
        {
            if (!clearFlag)
            {
                gameOverFlag = true;
                ////パネルを表示させる
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
