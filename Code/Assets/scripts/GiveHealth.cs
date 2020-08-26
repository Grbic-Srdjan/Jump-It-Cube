using UnityEngine;

public class GiveHealth : MonoBehaviour
{
    public AudioSource HealthTaken;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            PlayerController.health++;
            HealthTaken.Play(); 
            Destroy(gameObject); 
        }
    }
}
