using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathCountScript : MonoBehaviour
{
    //player 
    public Transform player;
    public TextMeshProUGUI tmp;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("UIScript script start");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerController controller = player.GetComponent<PlayerController>();
        Debug.Log("death count: " + controller.deathCount);
        tmp.text = controller.deathCount.ToString("0");
    }
}
