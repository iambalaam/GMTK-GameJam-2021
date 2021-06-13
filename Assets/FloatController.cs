using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FloatController : MonoBehaviour
{
    private float FORCE_MAGNITUDE = 100f;
    Vector2 _input;
    public Transform girl; 

    private void Update()
    {
    }

    public void OnRStick(InputAction.CallbackContext ctx)
    {
        _input = ctx.ReadValue<Vector2>();
    }
}
