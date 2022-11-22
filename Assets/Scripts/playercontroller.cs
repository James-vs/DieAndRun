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
[HideInInspector]
public SpriteRenderer spriteR;
public GameObject key;
public float coinCount = 0f;
public float deathCount = 0f;
public AudioSource jumpSoundEffect;
public AudioSource deathSoundEffect;
public AudioSource coinCollectSoundEffect;
public AudioSource keyAudio;




    // Start is called before the first frame update
void Start() { rb = GetComponent<Rigidbody2D>();
spriteR = gameObject.GetComponent<SpriteRenderer>();
key = GameObject.Find("Key");


}

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
        if(movementY > 0){
        jumpSoundEffect.Play();}
       }
       else{
       rb.AddForce(verticalmovement * jumpamount, ForceMode2D.Impulse);
       if(movementY > 0){
       jumpSoundEffect.Play();}
       }
      }

    if(isLookingRight){
      spriteR.flipX = false;
    }
    else{spriteR.flipX = true;}


    
    
    }



    

 

  void OnCollisionEnter2D(Collision2D other){



    if(other.gameObject.tag == "Ground" ){
    isGrounded = true;}
    if(other.gameObject.tag == "Hazards"){
      die();
    } else if (other.gameObject.CompareTag("Coin")) {
      coinCount += 1f;
      coinCollectSoundEffect.Play();
    } else if (other.gameObject.CompareTag("Key")) {
      keyAudio.Play();
    }
  
    
      
  }
  
  void OnCollisionExit2D(Collision2D other){
    if(other.gameObject.tag == "Ground"){
    isGrounded = false;}
       }

  void OnCollisionStay2D(Collision2D other){
     if(other.gameObject.tag == "Ground"){
    isGrounded = true;}
  }     

  public void die(){
    isGrounded = false;
    Instantiate(corpse, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);
    gameObject.transform.position =  new Vector3(-3.86f,-0.97f);
    deathCount += 1f;
    if(key != null){
    key.SetActive(true);};
    hasKey = false;
    deathSoundEffect.Play();
    Debug.Log("Coins collected: " + coinCount);
    Debug.Log("Died Again! Death count: " + deathCount);
  }

}      


