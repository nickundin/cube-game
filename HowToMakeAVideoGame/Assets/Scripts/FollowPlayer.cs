using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        // Camera transform position equal to player position
        transform.position = player.position + offset;
    }
}
