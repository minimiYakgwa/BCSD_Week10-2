using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float turnSpeed = 200f;
    private void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * turnSpeed);
    }
}
