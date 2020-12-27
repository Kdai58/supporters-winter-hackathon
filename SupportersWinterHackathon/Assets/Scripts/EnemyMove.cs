using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
    public float speed;
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
        playerPos = player.transform.position;
        dir = playerPos - this.transform.position;
        Debug.Log(dir);
        // if (dir.magnitude > 0.5) {
        //     //rb.AddForce(dir * speed);
        //     rb.velocity = dir * speed;
        //     Debug.Log(rb.velocity.magnitude);
        // }else {
        //     rb.velocity = dir * 0.0f;
        //     Debug.Log(rb.velocity.magnitude);
        // }
        rb.AddForce(dir * speed);
        
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
