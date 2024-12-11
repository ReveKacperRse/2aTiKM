using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    [SerializeField] float VectorX;
    [SerializeField] float VectorY = 0;
    [SerializeField] float VectorZ;
    [SerializeField] float speed = 10;
    [SerializeField] InputAction actionJump;
    Rigidbody rb;

    private void OnEnable()
    {
        actionJump.Enable();    
    }

    private void start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        VectorX = Input.GetAxis("Horizontal");
        VectorZ = Input.GetAxis("Vertical");
        VectorY = 0;
        transform.Translate(VectorX * Time.deltaTime * speed, VectorY * Time.deltaTime * speed, VectorZ * Time.deltaTime*speed);
    }
    private void FixedUpdate()
    {
        if (actionJump.IsPressed())
        {
            rb.AddForce(Vector3.up);
        }
    }
}
