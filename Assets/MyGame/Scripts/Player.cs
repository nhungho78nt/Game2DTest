using UnityEngine;
using UnityEngine.InputSystem.Processors;
[AddComponentMenu("DangSon/Player")]
public class Player : MonoBehaviour, IcanTakeDamage
{
    public int Maxhealth = 100;
    private int currentHealth;
    private bool isDead = false;
    private Animator anim;
    private int isDeadId;
    //private float timeDelay = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = Maxhealth;
        anim = GetComponentInChildren<Animator>();
        isDeadId = Animator.StringToHash("isDead");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int damageAmount, Vector2 hitPoint, GameObject hitDirection)
    {
        if (isDead) return;
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            isDead = true;
            DeadPlayer();
        }
        // Add hit reaction logic here if needed
    }
    private void DeadPlayer()
    {
        anim.SetTrigger(isDeadId);
    }
    public bool GetIsDead()
    {
        return isDead; 
    }
}
