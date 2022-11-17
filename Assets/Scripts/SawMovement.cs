using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawMovement : MonoBehaviour
{
    //fetching the Rigidbody2D component
    private Rigidbody2D rb;
    //variable to make the saw patrol
    public bool patrol;
    //variable to make the saw turn around
    private bool mustFlip;
    //variable to control the patrol speed
    public float patrolSpeed;
    //variable to check if there is ground underneath the saw
    public Transform groundDetector;
    //variable to assign which layer is ground
    public LayerMask groundLayer;
    //variable to get the body collider
    public Collider2D bodyCollider;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SawMovement script started");
        rb = gameObject.GetComponent<Rigidbody2D>();
        patrol = true;
    }

    // FixedUpdate is called once per frame, good with physics
    void FixedUpdate()
    {
        //transform.Rotate(new Vector3 (0f, 0f, 90f) * Time.deltaTime);
        if (patrol) {
            mustFlip = !Physics2D.OverlapCircle(groundDetector.position, 0.2f, groundLayer);
        }
    }

    void Update() {
        if (patrol) {
            Patrol();
        }
    }

    //function to control saw patrolling
    void Patrol() {
        if (mustFlip || bodyCollider.IsTouchingLayers(groundLayer)) {//
            TurnAround();
        }
        rb.velocity = new Vector2(patrolSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }

    //function to handle turning the saw around
    void TurnAround(){
        patrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        patrolSpeed *= -1;
        patrol = true;
    }
}
