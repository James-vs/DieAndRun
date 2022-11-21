using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    
    public void onClick(){
        Debug.Log("GAME PAUSED");
        Time.timeScale = 5;
    }
}
