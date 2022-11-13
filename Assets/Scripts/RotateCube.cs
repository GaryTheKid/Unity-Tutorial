using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public Rigidbody rb;

    public void RotateRB()
    {
        rb.AddTorque(new Vector3(0f, 0f, 10f), ForceMode.Impulse);
    }
}
