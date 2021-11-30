using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    // public GameManager gameManager;  Don't use this, Not good

    // public float jumpForce = 500f;
    public Rigidbody rb;
    void OnCollisionEnter(Collision collisionInfo)       // func already Exists so be careful
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            // GetComponent<PlayerMovement>().enabled = false;  can be like this also

            FindObjectOfType<GameManager>().EndGame();
            // to use FindObjectOfType there atleast should be one object of that type.

            FindObjectOfType<AudioManager>().Play("PlayerDeath");
        }

        if (collisionInfo.collider.tag == "Lava")
        {
            movement.enabled = false;
            // GetComponent<PlayerMovement>().enabled = false;  can be like this also

            FindObjectOfType<GameManager>().EndGame();
            // to use FindObjectOfType there atleast should be one object of that type.

            FindObjectOfType<AudioManager>().Play("LavaBurn");
        }

        if (collisionInfo.collider.tag == "Water")
        {
            movement.enabled = false;
            // GetComponent<PlayerMovement>().enabled = false;  can be like this also

            FindObjectOfType<GameManager>().EndGame();
            // to use FindObjectOfType there atleast should be one object of that type.

            FindObjectOfType<AudioManager>().Play("WaterSplash");
        }
        /*
        if (collisionInfo.collider.tag == "Jumper")
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        */
    }
}
