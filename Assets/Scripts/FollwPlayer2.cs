using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollwPlayer2 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(15, 2, 0);
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
