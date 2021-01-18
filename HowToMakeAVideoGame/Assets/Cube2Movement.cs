using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2Movement : MonoBehaviour
{

    public Rigidbody rb3;


    // Update is called once per frame
    void FixedUpdate()
    {
        rb3.AddForce(0, -1200 * Time.deltaTime, 0);
    }
}
