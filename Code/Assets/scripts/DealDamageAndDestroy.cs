using UnityEngine;

public class DealDamageAndDestroy : MonoBehaviour
{

    public int AmountOfDamageDeal;
    public GameObject EnemyAttack;
    public GameObject DieEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerController.health = PlayerController.health - AmountOfDamageDeal;
            Instantiate(EnemyAttack, transform.position, Quaternion.identity);
            EnemyAttack.SetActive(true);
            Instantiate(DieEffect, transform.position, Quaternion.identity); 
            Destroy(gameObject); 
        }
    }
}
