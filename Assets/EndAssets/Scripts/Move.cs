using System.Collections;
using UnityEngine;

public class Move : MonoBehaviour
{

    public Rigidbody rb1;
    public Rigidbody rb2;
    public Rigidbody rb3;
    public Rigidbody rb4;
    public Rigidbody rb5;
    public Rigidbody rb6;
    float speed = 10.0f;

    // Start is called before the first frame update
    void StartMovement()
    {
        Jump(rb1);
    }

    public void Jump(Rigidbody rb)
    {
        rb.AddForce(Vector3.up * speed, ForceMode.Impulse);
        StartCoroutine(Rotate(rb));
    }

    private IEnumerator Rotate(Rigidbody rb)
    {
        // Reset num for each Rigidbody
        while (rb.transform.rotation.eulerAngles.z < 180)
        {
            rb.transform.rotation = Quaternion.Euler(0, 0, rb.transform.rotation.eulerAngles.z + 1f);
        
            yield return new WaitForSeconds(0.001f);
        }
        if (rb.transform.rotation.eulerAngles.z >= 180)
        {
            // Determine the next Rigidbody to act upon
            if (rb == rb1) Jump(rb2);
            else if (rb == rb2) Jump(rb3);
            else if (rb == rb3) Jump(rb4);
            else if (rb == rb4) Jump(rb5);
            else if (rb == rb5) Jump(rb6);
            //else if (rb == rb6) Jump(rb1);
        }
    }
}