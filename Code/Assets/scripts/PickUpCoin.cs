using UnityEngine;

public class PickUpCoin : MonoBehaviour
{
    public GameObject PickUpCoinSoundEffect;
    public int CoinValue;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(PickUpCoinSoundEffect, transform.position, Quaternion.identity);
            PickUpCoinSoundEffect.SetActive(true);
            ScoringSystem.Score += CoinValue; 
            Destroy(gameObject); 
        }
    }
}
