using UnityEngine;

public class CubeController : MonoBehaviour
{
    private const float MOVE_SPEED = 5f;

    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * MOVE_SPEED * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * MOVE_SPEED * Time.deltaTime;
        }
    }
}
