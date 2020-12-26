using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class StartScript: MonoBehaviour {
    public void ChangeScene(){
        SceneManager.LoadScene("GameScene");
    }
    public void exit(){
        // UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}