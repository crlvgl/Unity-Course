using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Player")
        {
            Destroy(collider.gameObject);
            Debug.Log("Player has died");
            Scoring.gameOver = true;
        }
        else if (collider.gameObject.name == "Death")
        {
            Destroy(this.transform.parent.gameObject);
        }
    }
}
