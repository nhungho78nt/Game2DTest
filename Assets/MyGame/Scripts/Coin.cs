using UnityEngine;
[AddComponentMenu("DangSon/Coin")]
public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            GameManager.Instance.AddCoin(1);
            Destroy(gameObject);
        }
    }
}
