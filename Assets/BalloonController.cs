using UnityEngine;
using UnityEngine.InputSystem;

public class BalloonController : MonoBehaviour
{
    public Transform balloon;

    float BALLOON_SPEED = 3f;
    Vector2 balloonDirection;

    private void Update()
    {
        balloon.transform.position += (Vector3)balloonDirection * Time.deltaTime;
    }

    public void OnRStick(InputAction.CallbackContext context)
    {
        var input = context.ReadValue<Vector2>();
        if (input.magnitude > 3)
        {
            balloonDirection = input.normalized * 3f;
        } else
        {
            balloonDirection = input;
        }
    }
}
