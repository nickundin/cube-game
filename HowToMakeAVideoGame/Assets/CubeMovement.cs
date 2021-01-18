using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    // This is a reference to the RigidBody component called "rb2"
    public Rigidbody rb2;

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
    // Update is called once per frame
    void FixedUpdate()
    {
        rb2.AddForce(0, 0, -1000 * Time.deltaTime);
    }
}
