using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float LifeTime;

    private void Start()
    {
        Destroy(gameObject, LifeTime); 
    }
}
