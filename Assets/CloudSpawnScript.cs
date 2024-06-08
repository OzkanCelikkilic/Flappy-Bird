using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{
    public GameObject cloudPrefab;
    public float spawnRate = 20f;
    public float minHeight = -50f;
    public float maxHeight = 50f;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        // İlk bulutu oluştur
        SpawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        // Belirli bir süre sonra yeni bir bulut oluştur
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnCloud();
            timer = 0;
        }
    }

    void SpawnCloud()
    {
        // Rastgele yükseklikte bir bulut oluştur
        float randomHeight = Random.Range(minHeight, maxHeight);

        // Bulutu oluştur
        Instantiate(cloudPrefab, new Vector3(transform.position.x, randomHeight, 0), Quaternion.identity);
    }
}
