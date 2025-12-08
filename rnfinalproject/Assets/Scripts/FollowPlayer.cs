using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FollowPlayer : MonoBehaviour
{
    private Transform playerTransform;
    private Vector3 offset = new Vector3(0, 1, -4);


    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        transform.position = playerTransform.position + offset;
    }

    
    void Update()
    {
        transform.position = playerTransform.position + offset;
        
    }
}
