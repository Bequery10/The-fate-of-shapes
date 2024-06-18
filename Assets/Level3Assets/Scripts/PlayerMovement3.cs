using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement3 : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce=500f;
    public float jumpForce=5f;
    public float distanceToGround = 0.5f;
    void Start()
    {
        rb.useGravity = true;
        Cursor.visible = false;
    }

void OnCollisionEnter(Collision collision)
{
    // Check if the object we collided with has a tag "Obstacle"
    if (collision.gameObject.tag == "Meteor")
    {
       SceneManager.LoadScene("Level3"); 
    }
}
    void FixedUpdate()
    {

        if(transform.position.y<-100){
            SceneManager.LoadScene("Level3");
        }
        float extraGravityForce = -100f;  // Set this to the extra gravity force you want to apply
    rb.AddForce(new Vector3(0, extraGravityForce, 0));

       // rb.AddForce(0, 0, forwardForce * Time.deltaTime,ForceMode.VelocityChange);
Collider[] hitColliders = Physics.OverlapSphere(transform.position, transform.localScale.x/2);
//Debug.Log(hitColliders.Length);
bool isTouchingObject = hitColliders.Length > 1;

bool isGrounded = isTouchingObject;
        if (Input.GetKey("space") && isGrounded )
        {
            rb.AddForce(0, 1000*jumpForce * Time.deltaTime, 0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("w"))
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            rb.AddForce(3*forward.x*forwardForce * Time.deltaTime,3*forward.y*forwardForce * Time.deltaTime,3*forward.z*forwardForce * Time.deltaTime,ForceMode.VelocityChange);
        }

        if(Input.GetKey("s"))
        {
         Vector3 back = transform.TransformDirection(Vector3.back);
            rb.AddForce(3*back.x*forwardForce * Time.deltaTime,3*back.y*forwardForce * Time.deltaTime,3*back.z*forwardForce * Time.deltaTime,ForceMode.VelocityChange);
        }
        if(Input.GetKey("d"))
        {
             Vector3 back = transform.TransformDirection(Vector3.right);
            rb.AddForce(3*back.x*forwardForce * Time.deltaTime,3*back.y*forwardForce * Time.deltaTime,3*back.z*forwardForce * Time.deltaTime,ForceMode.VelocityChange);
              //transform.Rotate(Vector3.up, 1f);
        }
        if(Input.GetKey("a"))
        {
            Vector3 back = transform.TransformDirection(Vector3.left);
            rb.AddForce(3*back.x*forwardForce * Time.deltaTime,3*back.y*forwardForce * Time.deltaTime,3*back.z*forwardForce * Time.deltaTime,ForceMode.VelocityChange);
            // transform.Rotate(Vector3.down, 1f);
        }

            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            if(mouseX>0)
            {
                transform.Rotate(Vector3.up, mouseX*50);
            }
            else if(mouseX<0)
            {
                transform.Rotate(Vector3.up, mouseX*50);
            }
           

    }
}
