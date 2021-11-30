using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We marked it as "Fixed"Update because
	// We are using it to mess with physics.
	void FixedUpdate ()
    {
        // Add a forward force on the z-axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //rb.freezeRotation = true;

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        /*
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 50f * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        */
        if (rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
