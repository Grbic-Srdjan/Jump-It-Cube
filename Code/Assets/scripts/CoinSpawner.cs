using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject[] Coin;
    public int TimeToSpawn = 10;
    private float SpawnCounter = 0;
    private int RandomNumber, pom;

    private void Start()
    {
        pom = TimeToSpawn;
    }

    private void Update()
    {
        SpawnCounter++;
        if (SpawnCounter == 60)
        {
            SpawnCounter = 0;
            TimeToSpawn--;
        }
        if (TimeToSpawn <= 0)
        {
            RandomNumber = Random.Range(0, Coin.Length);
            Instantiate(Coin[RandomNumber], Coin[RandomNumber].transform.position, Quaternion.identity);
            TimeToSpawn = pom;
        }
    }
}
