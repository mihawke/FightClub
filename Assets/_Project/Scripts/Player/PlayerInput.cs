using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //reference to C# class
    private PlayerInputActions _actions;

    // properties for other scripts to access
    public Vector2 MoveInput { get; private set; }
    public bool AttackPressed { get; private set; }

    void Awake()
    {
        // We create a new "instance" of our control map.
        _actions = new PlayerInputActions();
    }

    //runs when object is activated
    private void OnEnable()
    {
        _actions.Enable();
    }

    //runs when object is destroyed
    private void OnDisable()
    {
        _actions.Disable();
    }

    //runs every frame
    private void Update()
    {
        MoveInput = _actions.Player.Move.ReadValue<Vector2>();
        AttackPressed = _actions.Player.Attack.WasPressedThisFrame();
    }
}
