using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private GameObject _player;
    Vector2 targetPosition = Vector2.zero;
    float standingDistace = 1f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (_player)
        {
            targetPosition.y = _player.transform.position.y;
            if (GetDirection() == -1)
            {
                targetPosition.x = _player.transform.position.x + standingDistace;
            }
            else
            {
                targetPosition.x = _player.transform.position.x + -standingDistace;
            }

            Vector2 newPosition = Vector2.MoveTowards(_rb.position, targetPosition, 2f * Time.fixedDeltaTime);
            _rb.MovePosition(newPosition);
        }
    }

    //Get direction in which player is standing
    private int GetDirection()
    {
        if (_rb.position.x - _player.transform.position.x >= 0)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }
}
