using UnityEngine;

public class MoveObstacles : MonoBehaviour
{
    public float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Scoring.gameOver)
        {
            return;
        }
        
        this.transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
