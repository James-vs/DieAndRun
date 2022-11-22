using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    float currentTime;
    public float startingTime = 100f;
    public float timeElapsed;
    public GameObject canvas;
    //public TextMeshProUGUI text;

    [SerializeField] TextMeshProUGUI countdownText;
    void Start()
    {
        currentTime = startingTime;
        timeElapsed = 0f;
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timeElapsed += 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if(currentTime < 0){
            var endscreenscript = canvas.GetComponent<EndScreenScript>().levelHasFailed = true; 
            //text.text = "Mission Failed!";
            GameObject.Find("BGMusic").GetComponent<AudioSource>().volume = 0;
            //GameObject.Find("Button").SetActive(false);
            //GameObject.Find("CoinsStar").SetActive(false);
            //GameObject.Find("DeathsStar").SetActive(false);
            //GameObject.Find("TimeTakenStar").SetActive(false);
        }

        //if (currentTime <= 0)
        //{
         //   currentTime = 0;
            // Your Code Here
        //}
    }
}