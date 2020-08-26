using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] Enemy;  
    public int TimeToSpawn = 5;
    private float SpawnCounter = 0;
    private int RandomNumber, pom;

    private void Start()
    {
        pom = TimeToSpawn; 
    }

    private void Update()
    {
        SpawnCounter++;
        if (SpawnCounter == 60) {
            SpawnCounter = 0;
            TimeToSpawn--; 
        }
        if (TimeToSpawn <= 0) {
            RandomNumber = Random.Range(0, Enemy.Length);
            Instantiate(Enemy[RandomNumber], transform.position, Quaternion.identity); 
            TimeToSpawn = pom;  
        }
    }
}
