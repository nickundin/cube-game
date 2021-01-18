using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 4000f;
    public float sidewaysForce = 100f;
    public float upwardForce = 60f;
   
    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    // Update is called once per frame
    void FixedUpdate() {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // right
        if ( Input.GetKey("d"))
        {
            // ForceMode.VelocityChange directly edits the velocity of an object and completely ignores its mass
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // left
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // jump
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, upwardForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        // dive
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, -upwardForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
