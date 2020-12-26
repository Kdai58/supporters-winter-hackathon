using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemiesController : MonoBehaviour
{

    public GameObject virus;
    private GameObject[] enemyObjects;
    public int xMin, xMax, yMin, yMax, zMin, zMax;
    public int gap;
    public int numberOfEnemies;

    // Start is called before the first frame update
    void Start()
    {
        xMin = -10;
        xMax = 11;
        yMin = 0;
        yMax = 11;
        zMin = -10;
        zMax = 10;
        gap = 1;
        numberOfEnemies = 5;
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning() {
        Vector3 spawnPoints = new Vector3(Random.Range(xMin, xMax),Random.Range(yMin, yMax),Random.Range(zMin, zMax));
        Instantiate(virus, spawnPoints, Quaternion.identity);

        enemyObjects = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemyObjects.Length != numberOfEnemies) {
            yield return new WaitForSeconds(gap);
            StartCoroutine(StartSpawning());
        }
    }

    // void SpawnEnemies() {
    //     for (int i = 0; i < 10; i++) {
    //         Vector3 spawnPoints = new Vector3(Random.Range(xMin, xMax),Random.Range(yMin, yMax),Random.Range(zMin, zMax));
    //         // Vector3 spawnPoints = new Vector3(0, -0.3f, 1);
    //         Instantiate(virus, spawnPoints, Quaternion.identity);
    //         Debug.Log(spawnPoints);
    //     }
    // }
}
