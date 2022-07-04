using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHit : MonoBehaviour
{
    private GameObject gManager;

    void Start()
    {
        gManager = GameObject.Find("GManager");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayerDamage()
    {
        gManager.GetComponent<GManager>().PlayerCheckCount();
    }
}
