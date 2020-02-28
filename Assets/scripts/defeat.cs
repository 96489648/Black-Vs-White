using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defeat : MonoBehaviour
{
    bool r = true;
    public Rigidbody2D rb;
    Vector2 acc; 

    private void Awake()
    {
        acc =  new Vector2(Random.Range(-14000,14000), Random.Range(8000, 14000));
        Invoke("destroy", 2f);
    }
    private void Update()
    {
        if (r)
        {
            rb.AddForce(acc);
            r = false;
        }
    }
    void destroy()
    {
        Destroy(gameObject);
    }
}
