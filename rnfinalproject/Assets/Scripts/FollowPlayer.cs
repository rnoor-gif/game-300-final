using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FollowPlayer : MonoBehaviour
{
    private Transform playerTransform;
    private Vector3 offset = new Vector3(0, 1, -4);

    public float rotateSpeed = 100.0f; // faster rotation

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        transform.position = playerTransform.position + offset;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            offset = Quaternion.AngleAxis(-rotateSpeed * Time.deltaTime, Vector3.up) * offset;
        }
        if (Input.GetKey(KeyCode.E))
        {
            offset = Quaternion.AngleAxis(rotateSpeed * Time.deltaTime, Vector3.up) * offset;
        }

        transform.position = playerTransform.position + offset;
        transform.LookAt(playerTransform);
    }
}
