using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackController : MonoBehaviour
{

    public GameObject arCamera;
    public GameObject smoke;

    public void Shoot() {
        RaycastHit hit;

        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit)) {
            Debug.Log("Hit!");
            // Debug.Log(hit.collider.CompareTag("Enemy"));
            Debug.Log(hit.transform.name);
            if (hit.collider.CompareTag("Enemy")) {
                Destroy(hit.transform.gameObject);
                Debug.Log("Destroy!");

                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }
    }
}
