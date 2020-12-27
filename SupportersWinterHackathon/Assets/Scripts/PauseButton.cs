using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public GameObject shootbutton;
    public GameObject crosshair;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject titlescreen;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        titlescreen.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
    }

    public void GamePauseResume()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            shootbutton.SetActive(false);
            crosshair.SetActive(false);
            titlescreen.SetActive(true);
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            shootbutton.SetActive(true);
            crosshair.SetActive(true);
            titlescreen.SetActive(false);
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
        }
    }    
}
