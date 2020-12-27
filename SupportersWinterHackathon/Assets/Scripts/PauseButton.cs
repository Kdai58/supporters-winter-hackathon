using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public GameObject shootbutton;
    public GameObject crosshair;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    public void GamePauseResume()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            shootbutton.SetActive(false);
            crosshair.SetActive(false);
        }
        else
        {
            Time.timeScale = 1;
            shootbutton.SetActive(true);
            crosshair.SetActive(true);
        }
    }    
}
