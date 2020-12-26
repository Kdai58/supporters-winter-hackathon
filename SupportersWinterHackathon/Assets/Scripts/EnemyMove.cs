using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
    public float speed = 0.1f;
    Vector3 dir, playerPos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        rb = GetComponent<Rigidbody>();
        playerPos = player.transform.position;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        dir = playerPos - this.transform.position;
        rb.AddForce(dir*speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.isTrigger == true)
        {
            Debug.Log("yay");
            player.GetComponent<PlayerScript>().TakeDamage();
        }
    }
}
