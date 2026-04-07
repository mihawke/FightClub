using UnityEngine;

public class Hurtbox : MonoBehaviour
{
    [SerializeField] private Health _health;

    public void PassDamage(int amount)
    {
        _health.TakeDamage(amount);
    }
}
