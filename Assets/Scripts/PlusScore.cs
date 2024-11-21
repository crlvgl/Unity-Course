using UnityEngine;

public class PlusScore : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GameObject.Find("CoinCollect").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Player")
        {
            Scoring.score += 1;
            audioSource.Play();
            Destroy(this.gameObject);
        }
    }
}
