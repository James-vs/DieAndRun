using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawMovement : MonoBehaviour
{
    //fetching the Rigidbody2D component
    private Rigidbody2D rb;
    //variable to control movement distance
    public float movementDistance = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SawMovement script started");
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // FixedUpdate is called once per frame, good with physics
    void FixedUpdate()
    {
        transform.Rotate(new Vector3 (0f, 0f, 90f) * Time.deltaTime);
    }
}
