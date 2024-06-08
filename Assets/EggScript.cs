using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggScript : MonoBehaviour
{

    public float moveSpeed = 100f;
    void Update()
    {
        transform.position = transform.position + (Vector3.right * moveSpeed) ;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
        
    }
}


