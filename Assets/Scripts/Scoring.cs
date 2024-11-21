using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    public static int score = 0;
    public static bool gameOver = false;
    public TMP_Text scoreText;
    public TMP_Text timerText;
    public TMP_Text gameOverText;
    public TMP_Text replayText;
    private float elapsedTime = 0f;
    private int minutes = 0;
    private int seconds = 0;
    private int milliseconds = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            scoreText.text = score.ToString() + "pts";

            elapsedTime += Time.deltaTime;

            minutes = (int)elapsedTime / 60;
            seconds = (int)elapsedTime % 60;
            milliseconds = (int)(elapsedTime * 1000) % 1000;

            timerText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds) + "s";
            gameOverText.text = "";
            replayText.text = "";
        }
        else
        {
            gameOverText.text = "Game Over!\nScore: " + score + "pts\nTime: " + string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds) + "s";
            scoreText.text = "";
            timerText.text = "";
            replayText.text = "Press 'E' to play again";
            elapsedTime = 0f;
        }
    }
}
