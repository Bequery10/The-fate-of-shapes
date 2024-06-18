
using UnityEngine;
using UnityEngine.SceneManagement; 
public class Next : MonoBehaviour
{
    public Transform player;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
         SceneManager.LoadScene("Level3"); 
       
        }
    }
}
