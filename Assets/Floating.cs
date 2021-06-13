using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Floating : MonoBehaviour
{
    public float bouyancy;
    public bool useGravity;

    private Rigidbody _body;

    private void Start()
    {
        _body = GetComponent<Rigidbody>();
        _body.useGravity = useGravity;
    }
    void FixedUpdate()
    {
        _body.velocity += Vector3.up * bouyancy;
    }
}
