using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnRate = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstacle()
    {
        if (!Scoring.gameOver)
        {
            yield return new WaitForSeconds(spawnRate);
            Instantiate(obstaclePrefab, new Vector3(this.transform.position.x, Random.Range(-3f, 3f), 0), Quaternion.identity);
            StartCoroutine(SpawnObstacle());
        }
    }
}
