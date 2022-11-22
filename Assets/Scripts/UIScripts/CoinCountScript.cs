using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCountScript : MonoBehaviour
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
        tmp.text = controller.coinCount.ToString("0");
    }
}
