
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    public Rigidbody rb;
  

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, 700*Time.deltaTime);


        if(Input.GetKey("d"))
        {
            rb.AddForce(600 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-600 * Time.deltaTime, 0, 0);
        }
    }
}
