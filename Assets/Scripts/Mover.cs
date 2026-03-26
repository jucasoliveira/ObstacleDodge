using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;


    private CharacterController controller;
    private Vector3 moveInput;
    private Vector3 moveVelocity;
    private InputAction moveAction;
    private float fixedY;


    void MovePlayer()
    {
        Vector2 input = moveAction.ReadValue<Vector2>();
        moveInput = new Vector3(input.x, 0f, input.y);
        moveVelocity = moveInput * Time.deltaTime * moveSpeed;

        controller.Move(moveVelocity);

        Vector3 pos = transform.position;
        pos.y = fixedY;
        transform.position = pos;
    }

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
        MovePlayer();
    }


    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        ObjectHit objectHit = hit.gameObject.GetComponent<ObjectHit>();
        if (objectHit != null)
        {
            objectHit.HandleHit();
        }
    }

    void OnDestroy()
    {
        moveAction?.Disable();
        moveAction?.Dispose();
    }
}
