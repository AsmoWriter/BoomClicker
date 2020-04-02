using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStartGame : MonoBehaviour
{
    [SerializeField]
    private GameObject _bombSpawner;
    [SerializeField]
    private GameObject _timerModeSpawner;
    [SerializeField]
    private GameObject _healthModeSpawner;
    [SerializeField]
    private GameObject _aboutGameWindow;

    [SerializeField]
    private GameObject _timerModeHUD;
    [SerializeField]
    private GameObject _healthModeHUD;


    public void OnStarTimerModetButtonClick()
    {
        gameObject.SetActive(false);
        _timerModeHUD.SetActive(true);
        _bombSpawner.SetActive(true);
        _timerModeSpawner.SetActive(true);
    }
    public void OnStarHealthModetButtonClick()
    {
        gameObject.SetActive(false);
        _healthModeHUD.SetActive(true);
        _bombSpawner.SetActive(true);
        _healthModeSpawner.SetActive(true);
    }
    public void OnAboutGameButtonClick()
    {
        _aboutGameWindow.SetActive(true);
    }
    public void OnCloseAboutGameButtonClick()
    {
        _aboutGameWindow.SetActive(false);
    }
}