using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumOfEnemy : MonoBehaviour
{
    public Text numOfEnemy;
    private GameObject[] enemyObjects;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");
        numOfEnemy.text="残り：" + enemyObjects.Length.ToString() + "体";
    }
}
