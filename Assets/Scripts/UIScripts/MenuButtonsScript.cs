using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonsScript : MonoBehaviour
{
public GameObject panel;
public GameObject mainPanel;

    public void okayButtonClick(){
        panel.SetActive(false);
        mainPanel.SetActive(true);
    }

    public void creditsButtonClick(){
      panel.SetActive(true);
      mainPanel.SetActive(false);
    }


}
