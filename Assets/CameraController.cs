using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    private Camera cam;
    public Transform cameraOrigin;

    private float CAMERA_SENSITIVITY = 0.002f;
    private float CAMERA_SPEED = 5f;
    private float CAMERA_DISTANCE = 10f;
    private float MAX_CAMERA_PITCH = Mathf.PI / 2;

    private float theta = Mathf.PI / 2;
    private float phi = Mathf.PI / 2;
    private float targetTheta = Mathf.PI / 2;
    private float targetPhi = Mathf.PI / 2;

    private Vector2 rStickInput;

    void Start()
    {
        cam = Camera.main;
    }
    void Update()
    {
        phi = Mathf.Lerp(phi, targetPhi, Time.deltaTime * CAMERA_SPEED);
        theta = Mathf.Lerp(theta, targetTheta, Time.deltaTime * CAMERA_SPEED);

        targetTheta += rStickInput.x * CAMERA_SENSITIVITY;
        targetPhi = Mathf.Clamp(
            targetPhi + rStickInput.y * CAMERA_SENSITIVITY,
            (Mathf.PI - MAX_CAMERA_PITCH) / 2,
            Mathf.PI - (Mathf.PI - MAX_CAMERA_PITCH) / 2
            );

        Vector3 targetPosition = new Vector3(
            CAMERA_DISTANCE * Mathf.Sin(theta) * Mathf.Sin(phi),
            CAMERA_DISTANCE * Mathf.Cos(phi),
            CAMERA_DISTANCE * Mathf.Cos(theta) * Mathf.Sin(phi)
        );

        cam.transform.position = targetPosition;
        cam.transform.LookAt(cameraOrigin);
    }

    public void OnRStick(InputAction.CallbackContext context)
    {
        Debug.Log("OnRStick()");
        var input = context.ReadValue<Vector2>();
        if (input.magnitude > 3)
        {
            rStickInput = input.normalized * 3;
        }
        else
        {
            rStickInput = input;
        }
    }
}
