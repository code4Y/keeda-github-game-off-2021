using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;    // player position
    public Vector3 offset;      // space between camer & player

	// Update is called once per frame
	void Update ()
    {
        transform.position = player.position + offset; 
        // used for the Main Camera to follow the Player with a offset/distance
	}
}
