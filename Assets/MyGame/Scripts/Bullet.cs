using UnityEngine;
[AddComponentMenu("DangSon/Bullet")]
public class Bullet : MonoBehaviour
{
    public float timeDestroy = 3f;
    public int damavalue = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, timeDestroy);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            IcanTakeDamage damageable = collision.GetComponent<IcanTakeDamage>();
            if(damageable != null)
            {
                damageable.TakeDamage(damavalue,Vector2.zero,gameObject);
            }
         Destroy(gameObject);
        }
    }
}
