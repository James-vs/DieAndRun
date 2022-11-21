using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Debug=UnityEngine.Debug;

public class TimeCountScript : MonoBehaviour
{
    //player 
    public Transform eventsSystem;
    public TextMeshProUGUI tmp;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Timer timer = eventsSystem.GetComponent<Timer>();
        Debug.Log("Time Elapsed: " + timer.timeElapsed);
        //Debug.Log("Time: " + timer.time.Elapsed);
        tmp.text = timer.timeElapsed.ToString("0");
    }
}
