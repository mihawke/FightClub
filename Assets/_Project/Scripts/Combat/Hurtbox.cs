using UnityEngine;

public class Hurtbox : MonoBehaviour
{
    private Health _health;

    private void Awake()
    {
        //look up in hierarchy for Health component
        _health = GetComponentInParent<Health>();
    }

    public void PassDamage(int amount)
    {
        _health.TakeDamage(amount);
    }
}
