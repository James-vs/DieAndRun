using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //player gameObject
    public GameObject player;

    //offsets for the camera
    public float yOffset = 0;
    private float zOffset = -1;
    //initial player y position
    private float cameraYPos = 0f;

    // Start is called before the first frame update
    void Start()
    {
        cameraYPos = player.gameObject.transform.position.y + yOffset;
        Debug.Log("FollowPlayer script started");
    }

    // Update is called once per frame
    void Update()
    {
        float playerYPosition = player.gameObject.transform.position.y;
        float playerXPosition = player.gameObject.transform.position.x;
        if(playerXPosition < 3f){
            transform.position = new Vector3(3f, cameraYPos + yOffset,zOffset);
        } //else if (playerYPosition > 5f) {
            //cameraYPos = -1f;
            //transform.position = new Vector3(playerXPosition, cameraYPos, playerZPosition - zOffset);
         else if (playerYPosition > 3f ) {//&& cameraYPos >= -1f
            transform.position = new Vector3(playerXPosition, cameraYPos + yOffset,zOffset);
        } else if (playerYPosition < 2f && playerYPosition >= 1f) {

            transform.position = new Vector3(playerXPosition, cameraYPos + yOffset,zOffset);
        }
        else if (playerYPosition < -2.5f && playerYPosition >= -3.5f) {

           transform.position = new Vector3(playerXPosition, cameraYPos + yOffset,zOffset);
        } else if (playerYPosition < -3.5f) {
            transform.position = new Vector3(playerXPosition, cameraYPos + yOffset,zOffset);
        }
        else {
            transform.position = new Vector3(playerXPosition, cameraYPos + yOffset,zOffset);
        }
    }
}