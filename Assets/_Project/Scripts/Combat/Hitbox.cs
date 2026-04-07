using UnityEngine;

public class Hitbox : MonoBehaviour
{
    [SerializeField] private int _damage = 10;
    [SerializeField] private LayerMask _targetLayer; // Optimized: Uses Layers instead of Tags

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 'collision.gameObject.layer' is just an ID (e.g., Layer 6).
        if (((1 << collision.gameObject.layer) & _targetLayer) != 0)
        {
            // Check IF the component exists AND assigns it to 'targetHealth' at the same time.
            if (collision.TryGetComponent(out Hurtbox hurtbox))
            {
                hurtbox.PassDamage(_damage);
            }
        }
    }
}
