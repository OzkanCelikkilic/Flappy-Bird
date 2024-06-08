using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMoveScript : MonoBehaviour
{
    public float minMoveSpeed = 1f;
    public float maxMoveSpeed = 3f;
    public float deadZone = -20f;

    // Start is called before the first frame update
    void Start()
    {
        // Rastgele bir hız belirle
        float randomSpeed = Random.Range(minMoveSpeed, maxMoveSpeed);
        // Bulutu belirli bir hızda sola hareket ettir
        GetComponent<Rigidbody2D>().velocity = Vector2.left * randomSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // Bulut belirli bir x pozisyonuna ulaştığında yok et
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
