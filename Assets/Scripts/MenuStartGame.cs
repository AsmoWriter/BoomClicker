using UnityEngine;

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
    private GameObject _timerModeControl;
    [SerializeField]
    private GameObject _healthModeControl;
    [SerializeField]
    private GameObject _timerModeHUD;
    [SerializeField]
    private GameObject _healthModeHUD;


    public void OnStarTimerModetButtonClick()
    {
        _timerModeControl.SetActive(true);
        gameObject.SetActive(false);
        _timerModeHUD.SetActive(true);
        _bombSpawner.SetActive(true);
        _timerModeSpawner.SetActive(true);
    }
    public void OnStarHealthModetButtonClick()
    {
        _healthModeControl.SetActive(true);
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