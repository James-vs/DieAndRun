using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Debug=UnityEngine.Debug;

public class TimeCountScript : MonoBehaviour
{
    //player 
    public Transform chest;
    public TextMeshProUGUI tmp;

    // Start is called before the first frame update
    void Start()
    {
        //kjdfkjd
    }

    // Update is called once per frame
    void Update()
    {
        ChestLogic timer = chest.GetComponent<ChestLogic>();
        Debug.Log("Time: " + timer.time.Elapsed);
        tmp.text = timer.time.ElapsedTicks.ToString("0");
    }
}
