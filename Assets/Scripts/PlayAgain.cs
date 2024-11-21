using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public string reloadButton = "e";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Scoring.gameOver)
        {
            if (Input.GetKeyDown(reloadButton))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Scoring.gameOver = false;
                Scoring.score = 0;
            }
        }
    }
}
