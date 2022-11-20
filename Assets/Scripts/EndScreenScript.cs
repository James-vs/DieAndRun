using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenScript : MonoBehaviour
{
    public bool levelHasEnded = false;
    public GameObject endLevelUI;
    private GameObject gameUI;

    // Update is called once per frame

    void Start(){
        gameUI = GameObject.Find("GameUI");
    }
    void Update()
    {
        if(levelHasEnded == true){
            endLevel();
        }
        else{notEndLevel();}
        
    }

    void endLevel(){
        endLevelUI.SetActive(true);
        gameUI.SetActive(false);
        Time.timeScale = 0f;
    }

    void notEndLevel(){
        endLevelUI.SetActive(false);
        gameUI.SetActive(true);
        Time.timeScale = 1f;
    }
}
