using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiClickListener : MonoBehaviour
{

    public GameObject MainPanel;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;
    public GameObject Panel5;
    public AudioSource clickSound;

    public void OpenPanel()
    {
        clickSound.Play();
        if (MainPanel != null)
        {
            bool isActive = MainPanel.activeSelf;

            MainPanel.SetActive(!isActive);
            Panel2.SetActive(false);
            Panel3.SetActive(false);
            Panel4.SetActive(false);
            Panel5.SetActive(false);


        }
    }

}
