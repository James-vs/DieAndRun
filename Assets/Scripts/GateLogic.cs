using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateLogic : MonoBehaviour
{
    private float startposx;
    private float startposy;
    private float startposz;
    public float movementspeed;
    public float distancemoveddown;
    private bool condition;
    public bool moveUp;

    // Start is called before the first frame update
    void Start()
    {
        startposy = gameObject.transform.position.y;
        startposx = gameObject.transform.position.x;
        startposz = gameObject.transform.position.z;
        condition = startposy - (distancemoveddown) < gameObject.transform.position.y;
        moveUp = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        condition = startposy - (distancemoveddown) < gameObject.transform.position.y;
        if(moveUp){
        if(condition){
        gameObject.transform.Translate(0,-1 * Time.deltaTime * movementspeed,0);}
        }
        else{
        if(startposy > gameObject.transform.position.y){gameObject.transform.Translate(0,1 * Time.deltaTime * movementspeed,0);}
        if(startposy < gameObject.transform.position.y){gameObject.transform.position = new Vector3(startposx,startposy,startposz);}
        }
        
        
        
    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Player"){
      if(other.gameObject.GetComponent<PlayerController>().hasKey == true){
        Debug.Log("move = true");
        moveUp = true;
      };
    
    }}
    
}
