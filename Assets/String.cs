using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(LineRenderer))]
public class String : MonoBehaviour
{
    public Transform anchor;
    private LineRenderer _line;
    // Start is called before the first frame update
    void Start()
    {
        _line = GetComponent<LineRenderer>();
        if (anchor== null)
        {
            _line.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3[] positions = new Vector3[2];
        positions[0] = transform.position;
        positions[1] = anchor.transform.position;
        _line.SetPositions(positions);
    }
}
