using UnityEngine;
using UnityEngine.InputSystem;

public class NewInputTest : MonoBehaviour
{
    InputAction moveAction;
    InputAction jumpAction;
    void Awake()
    {
        // Move 动作 + WASD 2D 复合绑定
        moveAction = new InputAction("Move", InputActionType.Value);
        moveAction.AddCompositeBinding("2DVector")
        .With("Up", "<Keyboard>/w")
        .With("Down", "<Keyboard>/s")
        .With("Left", "<Keyboard>/a")
        .With("Right", "<Keyboard>/d");
        moveAction.AddBinding("<Gamepad>/leftStick");
        jumpAction = new InputAction("Jump", InputActionType.Button, "<Keyboard>/space");
        jumpAction.AddBinding("<Gamepad>/buttonSouth");
        moveAction.performed += OnMove;
        moveAction.canceled += OnMove;
        jumpAction.performed += OnJump;
    }
    void OnMove(InputAction.CallbackContext context)
    {
        Vector2 v = context.ReadValue<Vector2>();
        Debug.Log("新版移动：" + v);
    }
    void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("新版跳跃");
    }
    void OnEnable()
    {
        moveAction.Enable();
        jumpAction.Enable();
    }
    void OnDisable()
    {
        moveAction.Disable();
        jumpAction.Disable();
    }
}
