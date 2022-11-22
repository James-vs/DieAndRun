using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenScript : MonoBehaviour
{
    public bool levelHasEnded = false;
    public bool levelHasFailed = false;
    public GameObject endLevelUI;
    public GameObject failLevelUI;
    public PlayerController playerController;
    public Timer timer;
    public int parCoins = 0;
    public int parDeaths = 0;
    public int parTime = 0;
    public GameObject coinsStar;
    public GameObject deathStar;
    public GameObject timeStar;

    private GameObject gameUI;


    // Update is called once per frame

    void Start(){
        gameUI = GameObject.Find("GameUI");
        playerController = GameObject.Find("player").GetComponent<PlayerController>();
        timer = GameObject.Find("EventSystem").GetComponent<Timer>();
    }
    void Update()
    {
        if(levelHasEnded == true){
            endLevel();
        } else if (levelHasFailed) {
            failLevel();
        }
        else{notEndLevel();}

        
        
    }

    void endLevel(){
        endLevelUI.SetActive(true);
        gameUI.SetActive(false);
        Time.timeScale = 0f;

        if(playerController.coinCount < parCoins){
            coinsStar.SetActive(false);
        }
        if(playerController.deathCount > parDeaths){
            deathStar.SetActive(false);
        }
        if(((int) timer.timeElapsed) > parTime){
            timeStar.SetActive(false);
        }
        
    }

    void failLevel(){
        failLevelUI.SetActive(true);
        gameUI.SetActive(false);
        Time.timeScale = 0f;
    }

    void notEndLevel(){
        endLevelUI.SetActive(false);
        //gameUI.SetActive(true);
        Time.timeScale = 1f;
    }
}
