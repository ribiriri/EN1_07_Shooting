using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update

    public int hp;

    private GameObject gManager;
    private GameObject playerObject;

    public float speed = 0.6f; 

    //ÉvÉåÉCÉÑÅ[ñ≥ìG

    void Start()
    {
        hp = 10;

        gManager = GameObject.Find("GManager");
        playerObject = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = transform.position;
   
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.z += speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.z-=speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed;
        }
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        if (hp <= gManager.GetComponent<GManager>().PlayerCheck()) 
        {
            Destroy(this.gameObject);
        }
     
    }

 

}
