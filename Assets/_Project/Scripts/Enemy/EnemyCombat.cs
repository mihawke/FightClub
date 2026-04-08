using UnityEngine;

public class EnemyCombat : MonoBehaviour
{
    [SerializeField] private GameObject _hitbox;
    [SerializeField] private float _attackDuration = 0.2f;

    private bool isMoving = true;
    private float attackCooldown = 2f;
    private float timer = 0f;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > attackCooldown && isMoving)
        {
            StartAttack();
            timer = 0f;
        }
    }

    private void StartAttack()
    {
        _hitbox.SetActive(true);

        Invoke(nameof(EndAttack), _attackDuration);
    }

    private void EndAttack()
    {
        _hitbox.SetActive(false);
    }
}
