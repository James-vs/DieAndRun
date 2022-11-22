using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyLogic : MonoBehaviour
{
  public GameObject player;

  void OnCollisionEnter2D(Collision2D other){
    

    if(other.gameObject.tag == "Player"){
      other.gameObject.GetComponent<PlayerController>().hasKey = true;
      gameObject.SetActive(false);
    }
    
      
  }
}
