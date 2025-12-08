using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CollectMarble : MonoBehaviour
{
    
    private Rigidbody marbleRb;
    private ParticleSystem collectEffect;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        marbleRb = GetComponent<Rigidbody>();
        collectEffect = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            collectEffect.Play();
            Destroy(gameObject);
        }
    }
}
