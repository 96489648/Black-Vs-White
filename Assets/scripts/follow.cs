using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public Transform cameraa;
    float  offset = 2.81f;
    Vector3 position = new Vector3();
    private void LateUpdate()
    {
        position.x = cameraa.position.x - offset;
        position.y = transform.position.y;
        position.z = transform.position.z;
        transform.position = position;   
    }
}
