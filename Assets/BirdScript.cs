using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public Transform EggSpawnPoint;
    public GameObject EggPrefab;
    public float eggSpeed =1000f;
    private int counter = 5;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && birdIsAlive)
        {
            if (counter > 0)
            {
            counter = counter - 1;  
                var egg = Instantiate(EggPrefab, EggSpawnPoint.position, EggSpawnPoint.rotation);
                egg.GetComponent<Rigidbody2D>().velocity = EggSpawnPoint.right * eggSpeed;
            }
     
       }

       if (Input.GetKeyDown(KeyCode.Space)&& birdIsAlive)
        {
            transform.Rotate(Vector3.forward, 90f);
            myRigidbody.velocity = Vector2.up * flapStrength;
         
        }

        if (transform.position.y > 22 || transform.position.y < -18){
            logic.gameOver();
        }
    }

  private void OnCollisionEnter2D(Collision2D collision)
  {
       logic.gameOver();
       birdIsAlive = false;
    }
}