using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // We marked it as "Fixed"Update because
	// We are using it to deal with physics.
	void FixedUpdate ()
    {
        // Add a forward force on the z-axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);


        if (Input.GetKey("d"))          // assign 'D' to move right
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))           // assign 'A' to move left
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < 0f)          // end game if player falls below the main ground
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
