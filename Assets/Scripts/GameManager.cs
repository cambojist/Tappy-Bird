using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool isAlive;
    private int _score;

    private UIManager _uiManager;

    private void Awake()
    {
        Instance = this;
        _uiManager = GameObject.Find("UI").GetComponent<UIManager>();
        _score = 0;
    }

    public void GameOver()
    {
        _uiManager.ShowGameOverScreen();
        Stop();
    }

    public void ChangeScore(int score)
    {
        _score += score;
        _uiManager.ChangeScore(_score);
    }

    public void Stop()
    {
        isAlive = false;
        Time.timeScale = 0;
    }

    public void Resume()
    {
        isAlive = true;
        Time.timeScale = 1;
    }
}