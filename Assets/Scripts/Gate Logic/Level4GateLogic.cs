using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4GateLogic : MonoBehaviour
{
    private float startposx;
    private float startposy;
    private float startposz;
    public float movementspeed;
    public float distancemoveddown;
    private bool condition;
    public bool moveUp;
    public GameObject player;

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
        
    
        if(player.GetComponent<PlayerController>().isLookingRight == false){
          moveUp = true;
          movementspeed = 3f;
        }
        else{
            moveUp = false;
            movementspeed = 1f;    
        }
        
        }    
        
        
    

    void OnCollisionEnter2D(Collision2D other){}
    
}
