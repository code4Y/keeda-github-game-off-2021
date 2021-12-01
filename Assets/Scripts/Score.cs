using UnityEngine;
using UnityEngine.UI;
using TMPro;    // to use text mesh pro

public class Score : MonoBehaviour {

    public Transform player;
    public TextMeshProUGUI scoreText;

    // Func. to calculate score
	// Update is called once per frame
	void Update () {
        
        scoreText.text = player.position.z.ToString("0");
	}
}
