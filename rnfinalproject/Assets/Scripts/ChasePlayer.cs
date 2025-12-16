using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChasePlayer : MonoBehaviour
{
    
    public float chaseSpeed = 9.0f;
    private Rigidbody enemyRb;
    private GameObject player;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

        enemyRb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationY;

    }


    void Update()
    {
        enemyRb.AddForce((player.transform.position - transform.position).normalized * chaseSpeed);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            enemyRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }

}
