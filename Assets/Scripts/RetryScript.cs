using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("RetryScript started");
    }

    // Update is called once per frame
    public void onClick(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
