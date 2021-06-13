using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    private float MOVE_SPEED = 3;

    private Vector2 _input;
    private CharacterController _controller;
    private Animator _animator;
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        
        Vector3 targetMovement = new Vector3(_input.x, 0, 0) * MOVE_SPEED * Time.deltaTime;
        _controller.Move(targetMovement);
        _animator.SetFloat("moveSpeed", targetMovement.magnitude);
    }

    public void OnLStick(InputAction.CallbackContext ctx)
    {
        _input = ctx.ReadValue<Vector2>();
    }
}
