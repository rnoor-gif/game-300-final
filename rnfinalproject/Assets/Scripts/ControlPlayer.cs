using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    
    private Rigidbody playerRb;
    public float speed = 5.0f;
    public float playerGravi;
    public float jumpPow = 10.0f;

    public bool isOnGround = true;

    public GameManager gameManager;
    
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= playerGravi;

        gameManager = FindObjectOfType<GameManager>();
    }

    
    void Update()
    {
        // Get camera directions (ignore vertical tilt)
        Vector3 camForward = Camera.main.transform.forward;
        Vector3 camRight   = Camera.main.transform.right;

        // Flatten so movement stays on ground plane
        camForward.y = 0;
        camRight.y = 0;
        camForward.Normalize();
        camRight.Normalize();

        // Apply input relative to camera
        float forwardInput = Input.GetAxis("Vertical");
        float rightInput   = Input.GetAxis("Horizontal");

        Vector3 moveDir = camForward * forwardInput + camRight * rightInput;
        playerRb.AddForce(moveDir * speed);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpPow, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Marble"))
        {
            gameManager.UpdateCount(1);
            Destroy(other.gameObject);
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }

        else if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
            gameManager.GameOver();
        }
    }
}
