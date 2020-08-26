using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(Vector2.right * Time.deltaTime); 
    }
}
