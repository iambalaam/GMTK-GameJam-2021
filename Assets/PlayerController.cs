using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    private float MOVE_SPEED = 8;
    private float MOVE_ACCN = 0.05f;

    private Vector2 _input;
    private Vector3 _currentMovement;
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
        Vector3 movement = Vector3.Lerp(_currentMovement, targetMovement, MOVE_ACCN);

        _controller.Move(movement);
        _animator.SetFloat("moveSpeed", movement.magnitude);
        _currentMovement = movement;
    }

    public void OnLStick(InputAction.CallbackContext ctx)
    {
        _input = ctx.ReadValue<Vector2>();
    }
}
