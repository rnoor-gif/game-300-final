using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    
    private Rigidbody playerRb;
    public float speed = 5.0f;
    public float playerGravi;
    public float jumpPow = 10.0f;

    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= playerGravi;
    }

    
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(Vector3.forward * speed * forwardInput);
        float rightInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.right * speed * rightInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpPow, ForceMode.Impulse);
        }

    }
}
