using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] private GameObject _hitbox;
    [SerializeField] private float _attackDuration = 0.2f;

    private PlayerInput _input;
    private bool _isAttacking = false;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();

        //Disable hitbox by default
        if (_hitbox != null) { _hitbox.SetActive(false); }
    }

    private void Update()
    {
        if (_input.AttackPressed && !_isAttacking)
        {
            StartAttack();
        }
    }

    private void StartAttack()
    {
        _isAttacking = true;
        _hitbox.SetActive(true);

        Invoke(nameof(EndAttack), _attackDuration);
    }

    private void EndAttack()
    {
        _hitbox.SetActive(false);
        _isAttacking = false;
    }
}
