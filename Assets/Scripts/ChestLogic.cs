using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;
using Debug=UnityEngine.Debug;

public class ChestLogic : MonoBehaviour
{

public GameObject canvas;
public GameObject player;
    // Start is called before the first frame 
//public Stopwatch time;
    
void Start() {
    //timer function
}

    // Update is called once per frame
void OnCollisionEnter2D(Collision2D other){
    if(other.gameObject.tag == "Player"){
        canvas.GetComponent<EndScreenScript>().levelHasEnded = true;
        other.gameObject.SetActive(false);
        //time.Stop();
        //Debug.Log(time.Elapsed);
    }
}
}
