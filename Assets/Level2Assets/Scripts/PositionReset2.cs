
using UnityEngine;

public class PositionReset2 : MonoBehaviour
{
    // Start is called before the first frame update

public Transform player;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
         player.position = new Vector3(0, 2, 0);
        // Debug.Log("Player has been reset");
        }
    }
}
