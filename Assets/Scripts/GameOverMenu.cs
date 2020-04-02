using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject _hpContol;
    [SerializeField]
    private GameObject _timeContol;
    [SerializeField]
    private GameObject _menuWindow;
    [SerializeField]
    private GameObject _bombSpawner;
    [SerializeField]
    private GameObject _timerModeSpawner;
    [SerializeField]
    private GameObject _healthModeSpawner;

    [SerializeField]
    private GameObject _timerModeHUD;
    [SerializeField]
    private GameObject _healthModeHUD;

    private string _modeName;

    public void OnRestartButtonClick()
    {
        GetAciveModeName();
        if (_modeName == "TimerMode")
        {
            gameObject.SetActive(false);
            _timerModeHUD.SetActive(true);
            _bombSpawner.SetActive(true);
            _timerModeSpawner.SetActive(true);
        }
        else if (_modeName == "HealthMode")
        {
            gameObject.SetActive(false);
            _healthModeHUD.SetActive(true);
            _bombSpawner.SetActive(true);
            _healthModeSpawner.SetActive(true);
        }
    }
    public void OnMenuButtonClick()
    {
        _hpContol.SetActive(false);
        _timeContol.SetActive(false);
        gameObject.SetActive(false);
        _menuWindow.SetActive(true);
    }

    public void GetAciveModeName()
    {
        if (_hpContol.activeSelf == true & _timeContol.activeSelf != true)
        {
            _modeName = "HealthMode";
        }
        else if (_hpContol.activeSelf != true & _timeContol.activeSelf == true)
        {
            _modeName = "TimerMode";
        }
    }
}
