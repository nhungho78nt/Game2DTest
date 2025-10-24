using UnityEngine;
[AddComponentMenu("DangSon/Bullet")]
public class Bullet : MonoBehaviour
{
    public GameObject fxPrefab;
    public float timeDestroy = 3f;
    public int damavalue = 10;
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, timeDestroy);
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            IcanTakeDamage damageable = collision.GetComponent<IcanTakeDamage>();
            Instantiate(fxPrefab, transform.position, Quaternion.identity);
            audioSource.Play();
            if (damageable != null)
            {
                damageable.TakeDamage(damavalue,Vector2.zero,gameObject);
            }
         Destroy(gameObject);
        }
    }
}
