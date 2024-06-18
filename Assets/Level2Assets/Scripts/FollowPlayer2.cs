
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    void Start()
    {

       
    }

void Update()
{
    float yRotationInRadians = player.eulerAngles.y * Mathf.Deg2Rad;
    Vector3 offset1 = new Vector3( (offset.z + offset.x)* (Mathf.Sin(yRotationInRadians) ),0, -(offset.z + offset.x)* ( 1 - Mathf.Cos(yRotationInRadians) ) );
    transform.position = player.position + offset + offset1;
    transform.rotation = player.rotation;
}

}
