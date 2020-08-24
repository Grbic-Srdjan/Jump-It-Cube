using UnityEngine;
using UnityEngine.UI; 

public class ScoringSystem : MonoBehaviour
{
    public static int Score = 0;
    public GameObject EnemyType2, ScoreText; 

    private void Update()
    {
        ScoreText.GetComponent<Text>().text = "score: " + Score; 
        if (Score == 25) EnemyType2.SetActive(true);  
    }
}
