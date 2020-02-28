using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
   
    [SerializeField] float speed = 4.7f;
    [HideInInspector] public bool movement = true;
 
    void Update()
    {
        if (movement)
        {
            transform.position += Time.deltaTime * speed * Vector3.right;
        }
       
    }
}
