using UnityEngine;
using UnityEngine.InputSystem;

public class CubeController : MonoBehaviour
{
    private const float MOVE_SPEED = 5f;
    private Vector2 direction = Vector2.zero;

    public Transform cube;

    void Update()
    {
        Vector2 move = direction * MOVE_SPEED * Time.deltaTime;
        cube.transform.position += new Vector3(move.x, move.y, 0);
    }

    public void OnLStick(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }

    public void OnRStick()
    {

    }

}
