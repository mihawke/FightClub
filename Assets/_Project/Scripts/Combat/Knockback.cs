using UnityEngine;

public class Knockback : MonoBehaviour
{
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void ApplyKnockback(float knockbackForce)
    {
        _rb.AddForce(new Vector2(knockbackForce, 0), ForceMode2D.Impulse);
    }
}
