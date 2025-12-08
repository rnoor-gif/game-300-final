using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollectMarble : MonoBehaviour
{
    
    private Rigidbody marbleRb;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        marbleRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
