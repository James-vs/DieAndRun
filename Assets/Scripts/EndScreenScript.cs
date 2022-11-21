using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenScript : MonoBehaviour
{
    public bool levelHasEnded = false;
    public GameObject endLevelUI;
    public PlayerController playerController;
    public Timer timer;
    public int parCoins = 0;
    public int parDeaths = 0;
    public int parTime = 0;
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
        }
        else{notEndLevel();}

        
        
    }

    void endLevel(){
        endLevelUI.SetActive(true);
        gameUI.SetActive(false);
        Time.timeScale = 0f;

        if(playerController.coinCount < parCoins){
            GameObject.Find("CoinsStar").SetActive(false);
        }
        if(playerController.deathCount > parDeaths){
            GameObject.Find("DeathsStar").SetActive(false);
        }
        if(((int) timer.timeElapsed) > parTime){
            GameObject.Find("TimeTakenStar").SetActive(false);
        }
        
    }

    void notEndLevel(){
        endLevelUI.SetActive(false);
        //gameUI.SetActive(true);
        Time.timeScale = 1f;
    }
}
