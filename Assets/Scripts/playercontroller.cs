using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
Rigidbody2D rb;
private float movementX;
private float movementY;
public float speed = 0;
public float jumpamount = 0;
public bool isGrounded = false;
public bool hasKey = false;
public GameObject corpse;
public bool isLookingRight = true;
public SpriteRenderer spriteR;


    // Start is called before the first frame update
void Start() { rb = GetComponent<Rigidbody2D>();
spriteR = gameObject.GetComponent<SpriteRenderer>();}

void OnMove(InputValue movementValue){
    Vector2 movementVector = movementValue.Get<Vector2>();
    movementX = movementVector.x;
    movementY = movementVector.y;
    }




void FixedUpdate(){
    Vector3 horizontalmovement = new Vector3(movementX,0);
    Vector4 verticalmovement = new Vector4(0,movementY);


    rb.AddForce(horizontalmovement * speed);
    if(movementX > 0){
      isLookingRight = true;
    }
    if(movementX < 0){
      isLookingRight = false;
    }
    

    if(isGrounded){
       if(movementX != 0){
        rb.AddForce(verticalmovement * jumpamount * 1.5f, ForceMode2D.Impulse);
       }
       else{
       rb.AddForce(verticalmovement * jumpamount, ForceMode2D.Impulse);}
      }

    if(isLookingRight){
      spriteR.flipX = false;
    }
    else{spriteR.flipX = true;}


    
    
    }



    

 

  void OnCollisionEnter2D(Collision2D other){
    Debug.Log(other.gameObject.tag);


    if(other.gameObject.tag == "Ground"){
    isGrounded = true;}
    else{isGrounded = false;}
    if(other.gameObject.tag == "Hazards"){
      die();
    }
  
    
      
  }
  
  void OnCollisionExit2D(Collision2D other){
    if(other.gameObject.tag == "Ground"){
    isGrounded = false;}
    else{
      isGrounded = true;
    }
       }

  void OnCollisionStay2D(Collision2D other){
     if(other.gameObject.tag == "Ground"){
    isGrounded = true;}
  }     

  void die(){
    isGrounded = false;
    Instantiate(corpse, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);
    gameObject.transform.position =  new Vector3(-3.86f,-0.97f);
  }

}      


