using UnityEngine;

public class ActivateAfterDeath : MonoBehaviour
{
    [SerializeField]
    private CounterScriptableObject _hpCounter;
    [SerializeField]
    private GameObject _gameOverConvas;

    private void FixedUpdate()
    {
        if (_hpCounter.Count <= 0)
        {
            _gameOverConvas.SetActive(true);
        }
    }
}
