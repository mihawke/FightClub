using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;
    private Knockback _knockback;

    private int _currentHealth;

    private void Awake()
    {
        _currentHealth = _maxHealth;
        _knockback = GetComponent<Knockback>();
    }

    public void TakeDamage(int amount)
    {
        _currentHealth -= amount;
        _knockback.ApplyKnockback(50f);

        Debug.Log("health :" + _currentHealth);


        if (_currentHealth <= 0)
        {
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }

}
