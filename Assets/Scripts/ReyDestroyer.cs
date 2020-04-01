using UnityEngine;

public class ReyDestroyer : MonoBehaviour
{
    [SerializeField]
    private CounterScriptableObject _scoreCounter;
    [SerializeField]
    private GameObject _plusScorePrefab;
    [SerializeField]
    private CounterScriptableObject _hpCounter;
    [SerializeField]
    private GameObject _plusHpPrefab;
    [SerializeField]
    private CounterScriptableObject _timerCounter;
    [SerializeField]
    private GameObject _plusTimePrefab;

    private bool _keyPressed;
    private string _bombTag = "BombTag";
    private string _timerTag = "TimerTag";
    private string _healthKitTag = "HealthKitTag";

    private void Update()
    {
        _keyPressed = Input.GetMouseButtonDown(0);

        if (!_keyPressed)
            return;

        Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D _hit = Physics2D.Raycast(ray, Vector2.zero);
        if (_hit.transform != null)
        {

            if (_hit.transform.tag == _bombTag)
            {
                Destroy(_hit.transform.gameObject);
                Instantiate(_plusScorePrefab, ray, Quaternion.identity);
                _scoreCounter.ChangeValue(1);
            }
            if (_hit.transform.tag == _timerTag)
            {
                Destroy(_hit.transform.gameObject);
                Instantiate(_plusTimePrefab, ray, Quaternion.identity);
                _timerCounter.ChangeValue(25);
            }
            if (_hit.transform.tag == _healthKitTag)
            {
                Destroy(_hit.transform.gameObject);
                Instantiate(_plusHpPrefab, ray, Quaternion.identity);
                _hpCounter.ChangeValue(10);
            }
        }
    }
}
