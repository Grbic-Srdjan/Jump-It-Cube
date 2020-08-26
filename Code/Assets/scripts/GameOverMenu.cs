using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class GameOverMenu : MonoBehaviour
{

    public GameObject FinalScore;

    public void playAgain()
    {
        SceneManager.LoadScene("Game");
        PlayerController.health = 3;
        ScoringSystem.Score = 0;
        PlayerController.EnemySpeed = 5f;
        PlayerController.SpeedCounter = 0f;
    }
    public void goBackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        PlayerController.health = 3;
        ScoringSystem.Score = 0;
        PlayerController.EnemySpeed = 5f;
        PlayerController.SpeedCounter = 0f;
    }

    private void Update()
    {
        FinalScore.GetComponent<Text>().text = "score: " + ScoringSystem.Score; 
    }
}
