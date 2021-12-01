using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        // calls completelevel when triggered (player passes through END)
    }

}
