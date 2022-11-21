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

        //if (currentTime <= 0)
        //{
         //   currentTime = 0;
            // Your Code Here
        //}
    }
}