using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 20f;
    private float h;
    private float w;
    private void Update()
    {
        h = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector3.up * speed * Time.deltaTime * h);
        w = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * w);
        //transform.Rotate(Vector3.forward, turnSpeed * w * Time.deltaTime);
        transform.Rotate(Vector3.left, turnSpeed * h * Time.deltaTime);

    }
}
