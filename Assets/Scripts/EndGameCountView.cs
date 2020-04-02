using UnityEngine;
using UnityEngine.UI;

public class EndGameCountView : MonoBehaviour
{
    [SerializeField]
    private CounterScriptableObject _scoreCounter;
    [SerializeField]
    private Text _countText;

    private void OnEnable()
    {
        _scoreCounter.ResetValue();
        _countText.text = _scoreCounter.PriorCount.ToString();
    }
}
