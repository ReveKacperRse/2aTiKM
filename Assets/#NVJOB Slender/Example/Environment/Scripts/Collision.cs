using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private AudioSource as;

    void Start()
    {
        as = GetComponent <AudioSource>();  
    }
    
    void onTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            as.Play("")
        }
    }
}
