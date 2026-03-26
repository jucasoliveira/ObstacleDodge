using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 moveInput;
    private Vector3 moveVelocity;
    private InputAction moveAction;
    private float fixedY;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        fixedY = transform.position.y;

        moveAction = new InputAction("Move", binding: "<Gamepad>/leftStick");
        moveAction.AddCompositeBinding("2DVector")
            .With("Left", "<Keyboard>/a")
            .With("Right", "<Keyboard>/d")
            .With("Down", "<Keyboard>/s")
            .With("Up", "<Keyboard>/w");
        moveAction.Enable();
    }

    void Update()
    {
        Vector2 input = moveAction.ReadValue<Vector2>();
        moveInput = new Vector3(input.x, 0f, input.y);
        moveVelocity = moveInput * Time.deltaTime * 10f;

        controller.Move(moveVelocity);

        Vector3 pos = transform.position;
        pos.y = fixedY;
        transform.position = pos;
    }

    void OnDestroy()
    {
        moveAction?.Disable();
        moveAction?.Dispose();
    }
}
