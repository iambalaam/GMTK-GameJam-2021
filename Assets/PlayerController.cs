using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    private float DEAD_ZONE = 0.3f;
    private float MOVE_SPEED = 8;
    private float MOVE_ACCN = 0.05f;
    private float TURN_ACCN = 0.08f;
    private float _currentRoatation = 100;
    private float targetRotation = 100;

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
        if (_input.x > 0) targetRotation = 100;
        if (_input.x < 0) targetRotation = 260;


        Vector3 targetMovement = new Vector3(_input.x, 0, 0) * MOVE_SPEED * Time.deltaTime;
        float rotation = Mathf.Lerp(_currentRoatation, targetRotation, TURN_ACCN);
        Vector3 movement = Vector3.Lerp(_currentMovement, targetMovement, MOVE_ACCN);

        _controller.Move(movement);
        transform.rotation = Quaternion.Euler(0, rotation, 0);
        _animator.SetFloat("moveSpeed", movement.magnitude); ;
        _currentMovement = movement;
        _currentRoatation = rotation;
    }

    public void OnLStick(InputAction.CallbackContext ctx)
    {
        _input = ctx.ReadValue<Vector2>();
        if (Mathf.Abs(_input.x) < DEAD_ZONE)
        {
            _input.x = 0;
        }
    }
}
