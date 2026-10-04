using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score;
    public Text scoreText;
    public GameObject gameOverPanel;
    public PlayerController playerController;
    public CoinSpawner coinSpawner;

    private bool isGameOver;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        ResetGame();
    }

    public void ResetGame()
    {
        score = 0;
        isGameOver = false;
        if (scoreText != null)
            scoreText.text = "Score: 0";

        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);

        if (playerController != null)
            playerController.enabled = true;

        if (coinSpawner != null)
            coinSpawner.enabled = true;
    }

    public void AddScore(int value)
    {
        if (isGameOver)
            return;

        score += value;
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        if (isGameOver)
            return;

        isGameOver = true;

        if (playerController != null)
            playerController.enabled = false;

        if (coinSpawner != null)
            coinSpawner.enabled = false;

        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);
    }
}
