using UnityEngine;
using UnityEngine.UI;  

public class UpdateHighScore : MonoBehaviour
{
    public Text HighScoreText;

    private void Start()
    {
        HighScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString(); 
    }

    private void Update()
    {
        if (ScoringSystem.Score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", ScoringSystem.Score);
            HighScoreText.GetComponent<Text>().text = "Your highscore: " + ScoringSystem.Score; 
        }
    }

}
