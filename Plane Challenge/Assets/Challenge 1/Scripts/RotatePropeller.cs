using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    private GameObject propeller;
    private float rotationSpeed = 30000.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void LateUpdate()
    {
        propeller = GameObject.Find("Propeller");
        propeller.transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
