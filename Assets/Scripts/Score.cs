using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour {

    public Transform player;
    public TextMeshProUGUI scoreText;

    // Func. to calculate score
	// Update is called once per frame
	void Update () {
        
        scoreText.text = player.position.z.ToString("0");
	}
}
