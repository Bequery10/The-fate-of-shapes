using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            SceneManager.LoadScene("Level1");
        }
        else if(collisionInfo.collider.tag == "Next")
        {
             SceneManager.LoadScene("Level2");
        }
    }
     void Update(){
    if(transform.position.y<0){
         SceneManager.LoadScene("Level1");
    }
   }
}
