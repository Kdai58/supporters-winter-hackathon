using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearCondtionController : MonoBehaviour
{
    private GameObject[] enemyObjects;

    void Update()
    {

        enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");

        Debug.Log(enemyObjects.Length);

        if (enemyObjects.Length == 0)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}