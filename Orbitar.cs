using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbitar : MonoBehaviour
{

    public Transform sol;

    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.RotateAround(sol.position, Vector3.up, velocidad* Time.deltaTime );
    }
}
