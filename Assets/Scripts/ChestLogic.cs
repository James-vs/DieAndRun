using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestLogic : MonoBehaviour
{

public GameObject canvas;
public GameObject player;
    // Start is called before the first frame update
    

    // Update is called once per frame

void OnCollisionEnter2D(Collision2D other){
    if(other.gameObject.tag == "Player"){
        canvas.GetComponent<EndScreenScript>().levelHasEnded = true;
        Destroy(player);
    }
}
}
