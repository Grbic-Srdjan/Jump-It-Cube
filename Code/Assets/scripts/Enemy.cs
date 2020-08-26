using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector2.left * (float)PlayerController.EnemySpeed * Time.deltaTime);
        PlayerController.SpeedCounter += 1 * Time.deltaTime;
        if (PlayerController.SpeedCounter >= 60f) {
            PlayerController.EnemySpeed += 10 * Time.deltaTime;    
            PlayerController.SpeedCounter = 0f;
        }
    }
}
