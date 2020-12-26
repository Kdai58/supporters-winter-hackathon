using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public int HP;
    public GameObject HPtext;
    private Text UItext;
    void Start(){
        HP = 10;
        UItext = HPtext.GetComponent<Text>();
        UItext.text = "HP: " + HP.ToString();
    }

    public void TakeDamage(){
        HP=HP-1;
        UItext.text = "HP: " + HP.ToString();
        if (HP <= 0){
            Debug.Log("dead~");
            SceneManager.LoadScene("GameOverScene");
        }
    }
}