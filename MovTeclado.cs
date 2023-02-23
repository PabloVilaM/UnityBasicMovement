using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTeclado : MonoBehaviour
{
    private int speed = 150;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Me inicio");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      float h =  Input.GetAxis("Horizontal");
      float v = Input.GetAxis("Vertical");

        Vector3 vector = new Vector3(h, 0.5f, v);
        
        rb.AddForce(vector*speed*Time.deltaTime);
    }
}
