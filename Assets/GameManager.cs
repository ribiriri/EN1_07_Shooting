using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    //public TextAlignment playerHP;

    public void ChangeScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void playerHP_down()
    { 
    
    
    
    }
}
