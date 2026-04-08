using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    private PlayerInput _playerInput;
    private Rigidbody2D _rb;
    private bool _facingRight = true;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float vertical = _playerInput.MoveInput.y * (0.7f * moveSpeed);
        float horizontal = _playerInput.MoveInput.x * moveSpeed;

        _rb.linearVelocity = new Vector2(horizontal, vertical);

        //handle flip
        if (horizontal > 0 && !_facingRight) Flip();
        else if (horizontal < 0 && _facingRight) Flip();
    }

    private void Flip()
    {
        _facingRight = !_facingRight;

        // Flip the entire Player object along x-axis
        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;
    }

}
