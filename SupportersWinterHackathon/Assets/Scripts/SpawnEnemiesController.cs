using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemiesController : MonoBehaviour
{

    public GameObject virus;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies();
    }

    void SpawnEnemies() {
        for (int i = 0; i < 10; i++) {
            Vector3 spawnPoints = new Vector3(Random.Range(-2, 2),Random.Range(0, 2),Random.Range(-2, 2));
            // Vector3 spawnPoints = new Vector3(0, -0.3f, 1);
            Instantiate(virus, spawnPoints, Quaternion.identity);
            Debug.Log(spawnPoints);
        }
    }
}
