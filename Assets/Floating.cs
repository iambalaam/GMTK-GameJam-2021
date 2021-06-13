using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Floating : MonoBehaviour
{
    private Rigidbody _body;

    private float bouyancy = 0.2f;

    private void Start()
    {
        _body = GetComponent<Rigidbody>();
        _body.useGravity = false;
    }
    void Update()
    {
        _body.velocity += Vector3.up * bouyancy;
    }
}
