using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float health = 100f;
    private float currentHelath;
    private void Awake()
    {
        currentHelath = health;
    }
    public void TakeDamage(int damage)
    {
        currentHelath -= 10f;
        Debug.Log("Enemy health: " + currentHelath);
    }
}
