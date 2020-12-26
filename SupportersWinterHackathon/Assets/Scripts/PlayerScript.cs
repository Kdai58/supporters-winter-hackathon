using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public int HP;
    public Text HPtext;
    // private Text UItext;
    void Start(){
        // UItext = HPtext.GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        HPtext.text = HP.ToString();
        if (HP <= 0){
            Debug.Log("dead~");
            SceneManager.LoadScene("ClearScene");
        }
    }

    public void TakeDamage(){
        HP=HP-1;
        Debug.Log("HP--");
        Debug.Log(HP);
    }
}
