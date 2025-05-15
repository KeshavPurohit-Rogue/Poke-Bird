using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerScore;
    public Text ScoreText;
    public GameObject gameOverScreen;
    [ContextMenu("Increase Score")]
    public void addScore(int ScoreToAdd) { 
       playerScore = playerScore+ ScoreToAdd;   
        ScoreText.text= playerScore.ToString();
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver() {
        gameOverScreen.SetActive(true);
    }
}
