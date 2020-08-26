using UnityEngine;
using UnityEngine.UI; 

public class UpdatingHighScore : MonoBehaviour
{
    public Text YourHS;

    void Start()
    {
        YourHS.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    void Update()
    {
        if (ScoringSystem.Score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", ScoringSystem.Score);
            YourHS.GetComponent<Text>().text = "Your highscore: " + ScoringSystem.Score;
        }
    }

}
