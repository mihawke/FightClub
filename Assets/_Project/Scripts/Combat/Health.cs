using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;
    private int _currentHealth;

    // Defining events
    public UnityEvent OnTakeDamage;
    public UnityEvent OnDeath;

    private void Awake() => _currentHealth = _maxHealth;

    public void TakeDamage(int amount)
    {
        _currentHealth -= amount;
        Debug.Log("health :" + _currentHealth);
        
        // The ?. means "Only broadcast if someone is actually listening"
        OnTakeDamage?.Invoke();

        if (_currentHealth <= 0)
        {
            OnDeath?.Invoke();
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
