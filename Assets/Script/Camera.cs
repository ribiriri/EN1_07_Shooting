using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject player;

    private float posXset;
    private float posYset;
    private float posZset;

    // Start is called before the first frame update
    void Start()
    {
        posXset = transform.localPosition.x;
        posYset = transform.localPosition.y;
        posZset = transform.localPosition.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            float x = player.transform.localPosition.x + posXset;
            float y = player.transform.localPosition.y + posYset;
            float z = player.transform.localPosition.z + posZset;


            Vector3 newLocalPos = new Vector3(x, y, z);
            transform.localPosition = Vector3.Lerp(transform.localPosition, newLocalPos, 1);
        }

    }
}
