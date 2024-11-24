using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject obstaclePrefab2;
    public GameObject obstaclePrefab3;
    public GameObject obstaclePrefab4;
    public float spawnRate = 2f;
    private int randomObstacle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnFirstObstacle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnFirstObstacle()
    {
        yield return new WaitForSeconds(spawnRate*1.5f);
        Instantiate(obstaclePrefab, new Vector3(this.transform.position.x, Random.Range(-3f, 3f), 0), Quaternion.identity);
        StartCoroutine(SpawnObstacle());
    }

    IEnumerator SpawnObstacle()
    {
        if (!Scoring.gameOver)
        {
            yield return new WaitForSeconds(spawnRate);
            randomObstacle = Random.Range(1, 5);
            if (randomObstacle == 1)
            {
                Instantiate(obstaclePrefab, new Vector3(this.transform.position.x, Random.Range(-3f, 3f), 0), Quaternion.identity);
            }
            else if (randomObstacle == 2)
            {
                Instantiate(obstaclePrefab2, new Vector3(this.transform.position.x, Random.Range(-3f, 3f), 0), Quaternion.identity);
            }
            else if (randomObstacle == 3)
            {
                Instantiate(obstaclePrefab3, new Vector3(this.transform.position.x, Random.Range(-3f, 3f), 0), Quaternion.identity);
            }
            else
            {
                Instantiate(obstaclePrefab4, new Vector3(this.transform.position.x, Random.Range(-3f, 3f), 0), Quaternion.identity);
            }
            StartCoroutine(SpawnObstacle());
        }
    }
}
