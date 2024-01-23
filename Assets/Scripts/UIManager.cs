using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private GameObject _gameOverGo;
    private TMP_Text _score;

    private void Start()
    {
        _score = GameObject.Find("Score").GetComponent<TMP_Text>();
        _gameOverGo = transform.Find("Game Over Screen").gameObject;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        _gameOverGo.SetActive(false);
    }

    public void GameRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameManager.Instance.Resume();
        _gameOverGo.SetActive(false);
    }

    public void ShowGameOverScreen()
    {
        _gameOverGo.SetActive(true);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void ChangeScore(int score)
    {
        _score.text = score.ToString();
    }
}