using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public void Start()
    {
        scoreText.text = score.ToString();
    }

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
