using UnityEngine;
using UnityEngine.UI;

public class TargetBehaviour : MonoBehaviour
{
    public float health = 100f;
    public Text damageInfo;
    public void Start()
    {
        
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        damageInfo.text = $"Target Health: {health} Damage: {damage}";

        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
