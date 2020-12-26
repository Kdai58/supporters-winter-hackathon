using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    
    public static float HP;
    private float InitHP = 100;
    private float RangeOfDamege = 0.1f;
    public GameObject HPtext;
    private Text UItext;
    void Start(){
        HP = InitHP;
        UItext = HPtext.GetComponent<Text>();
        UItext.text = "HP: " + HP.ToString();
    }

    public void TakeDamage(){
        HP -= InitHP * RangeOfDamege;
        UItext.text = "HP: " + HP.ToString();
        if (HP <= 0){
            Debug.Log("dead~");
            SceneManager.LoadScene("GameOverScene");
        }
    }
}