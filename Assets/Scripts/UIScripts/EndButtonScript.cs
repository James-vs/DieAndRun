using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButtonScript : MonoBehaviour
{
    public void endButtonPressed(){
        SceneManager.LoadScene(0);
    }
}
