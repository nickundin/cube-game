using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // public, name of script, give variable a name
    public PlayerMovement movement;

    // Collision collisionInfo lets Unity know we want to gather some info about the collision
    private void OnCollisionEnter (Collision collisionInfo)
    {
        // collisionInfo displays what we hit
        // first dot accesses different parts of this info
        // second dot gets some info about that collider
        // Debug.Log(collisionInfo.collider.name);

        // so...
        // checking for collider name is inefficient; use tags instead
        // if (collisionInfo.collider.name == "Obstacle")
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an obstacle!");

            // if the player hits an obstacle, the player's movement is stopped
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
