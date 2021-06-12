using UnityEngine;
using UnityEngine.InputSystem;

public class CubeController : MonoBehaviour
{
    private const float MOVE_SPEED = 5f;
    private Vector2 direction = Vector2.zero;

    private void Start()
    {
        LevelManager.instance.LoadScene(LevelManager.Scene.Lv2);
    }

    void Update()
    {
        Vector2 move = direction * MOVE_SPEED * Time.deltaTime;
        transform.position += new Vector3(move.x, move.y, 0);

        if (transform.position.y > 4)
        {
            LevelManager.instance.NextScene();
        }
    }

    public void OnLStick(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }

    public void OnRStick()
    {

    }

}
