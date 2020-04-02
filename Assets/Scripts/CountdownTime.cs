using UnityEngine;
using System.Collections;

public class CountdownTime : MonoBehaviour
{
    [SerializeField]
    private CounterScriptableObject _timeCounter;

    private Coroutine _countdownRoutine;

    private void OnEnable()
    {
        _countdownRoutine = StartCoroutine(CountdownRoutine);
    }

    private void OnDisable()
    {
        if (_countdownRoutine != null)
            StopCoroutine(_countdownRoutine);
        _countdownRoutine = null;
    }

    private IEnumerator CountdownRoutine
    {
        get
        {
            while (true)
            {
                _timeCounter.ChangeValue(-1);
                yield return new WaitForSeconds(1);
            }
        }
    }
}
