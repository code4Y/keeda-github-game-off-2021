using UnityEngine;
using UnityEngine.SceneManagement; //Change scene & reload scene

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            
            Invoke("Restart", restartDelay);  // introduce delay of x seconds
        }       
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
