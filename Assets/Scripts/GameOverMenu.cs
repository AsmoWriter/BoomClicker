using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField]
    private ScoreCounterScriptableObject Scores;
    [SerializeField]
    private HPCounterScriptableObject HP;
    [SerializeField]
    private GameObject UICanvas;

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
        Scores.OnEnable();
        Scores.AddValue(0);
        gameObject.SetActive(false);
        UICanvas.SetActive(false);
        HP.OnEnable();
        HP.AddValue(0);
    }

}
