using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoPushForward : MonoBehaviour
{
    public float force = 10f;

    // Use this for initialization
    void Start()
    {
        
    }
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 fDir = new Vector3(moveHorizontal, 0.0f, moveVertical);
        fDir.Normalize();
        GetComponent<Rigidbody>().AddForce(fDir * force);
    }
}
