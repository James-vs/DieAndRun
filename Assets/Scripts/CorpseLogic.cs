using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorpseLogic : MonoBehaviour
{

private SpriteRenderer spriteR;    
public float disappearDelay;
public int disappearSpeed;
    // Start is called before the first frame update

    void Start(){
        spriteR = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        disappearDelay -= (Time.deltaTime/disappearSpeed);

        spriteR.color = new Color (0f,0.4323421f,1f,disappearDelay);    
        if(disappearDelay < 0){Destroy(gameObject);}
    }
}
