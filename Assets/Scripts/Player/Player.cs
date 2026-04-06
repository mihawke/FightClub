using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb; //referece variable

    //C# class generated via PlayerInputActions input system
    private PlayerInputActions playerInputActions;
    public float moveSpeed = 1f;
    private Vector2 moveInput;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        
        //find component of type Rigidbody2D, attached to same gameobject as that of script
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        playerInputActions.Enable();
    }

    private void OnDisable()
    {
        playerInputActions.Disable();
    }

    void Update()
    {
        //read input as Vecto2 adn store
        moveInput = playerInputActions.Player.Move.ReadValue<Vector2>();
    }
    void FixedUpdate()
    {
        rb.linearVelocity = moveInput * moveSpeed;
    }
}
