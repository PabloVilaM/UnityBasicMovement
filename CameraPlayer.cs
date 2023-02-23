using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public GameObject padre;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = padre.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    { 
        float mouse = Input.GetAxis("Mouse Y");
        float mouse2 = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(-mouse*1,mouse2*2,0));
        gameObject.transform.position = padre.transform.position;
    }
}
