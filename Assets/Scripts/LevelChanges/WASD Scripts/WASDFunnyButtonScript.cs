using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDFunnyButtonScript : MonoBehaviour
{

    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void onClick(){
        player = GameObject.Find("player");
        player.GetComponent<WASDPlayerController>().die();
    }
}