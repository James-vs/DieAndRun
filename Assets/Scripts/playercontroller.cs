using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class playercontroller : MonoBehaviour
{
Rigidbody2D rb;
private float movementX;
private float movementY;
public float speed = 0;
public float jumpamount = 0;
public bool isGrounded = false;
public bool hasKey = false;


    // Start is called before the first frame update
void Start() { rb = GetComponent<Rigidbody2D>(); }

void OnMove(InputValue movementValue){
    Vector2 movementVector = movementValue.Get<Vector2>();
    movementX = movementVector.x;
    movementY = movementVector.y;
    }




void FixedUpdate(){
    Vector3 horizontalmovement = new Vector3(movementX,0);
    Vector4 verticalmovement = new Vector4(0,movementY);
    rb.AddForce(horizontalmovement * speed);
    if(movementX != 0){}
    if(isGrounded){
       if(movementX != 0){
        rb.AddForce(verticalmovement * jumpamount * 1.5f, ForceMode2D.Impulse);
       }
       else{
       rb.AddForce(verticalmovement * jumpamount, ForceMode2D.Impulse);}
      } 

      }


    

 

  void OnCollisionEnter2D(Collision2D other){
    Debug.Log(other.gameObject.tag);


    if(other.gameObject.tag == "Ground"){
    isGrounded = true;}
    else{isGrounded = false;}
    if(other.gameObject.tag == "Hazards"){
      Destroy(gameObject);
    }
  
    
      
  }
  
  void OnCollisionExit2D(Collision2D other){
    if(other.gameObject.tag == "Ground"){
    isGrounded = false;}
    else{
      isGrounded = true;
    }
       }

}      


