using UnityEngine;

public class Cube1Movement : MonoBehaviour
{

    public Rigidbody rb2;
    public float forwardForce = 1500f;
    public float sidewaysForce = 600f;

    // Update is called once per frame
    void Update()
    {

        rb2.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("a"))
        {
            rb2.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("d"))
        {
            rb2.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
