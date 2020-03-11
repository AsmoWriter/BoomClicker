using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField]
    private CounterScriptableObject _scoreCounter;
    [SerializeField]
    private CounterScriptableObject _hpCounter;
    [SerializeField]
    private GameObject _uiCanvas;

    public void OnRestartButtonClick()
    {
        UpdateUIOnNewGame();

        SceneManager.LoadScene("MineScene", LoadSceneMode.Single);
    }
    public void OnMenuButtonClick()
    {
        UpdateUIOnNewGame();

        SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
    }
    public void UpdateUIOnNewGame()
    {
        _scoreCounter.OnEnable();
        _scoreCounter.ChangeValue(0);
        gameObject.SetActive(false);
        _uiCanvas.SetActive(false);
        _hpCounter.OnEnable();
        _hpCounter.ChangeValue(0);
    }

}
