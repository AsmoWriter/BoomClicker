using UnityEngine;
using UnityEngine.UI;

public class ScoreCounterUpdateView : MonoBehaviour
{
    [SerializeField]
    private Text _countText;
    [SerializeField]
    private ScoreCounterScriptableObject _counterScriptableObject;

    private void Awake()
    {
        _counterScriptableObject.UpdateScore += UpdateCounter;
    }

    private void OnEnable()
    {
        UpdateCounter(_counterScriptableObject.Count);
    }

    private void UpdateCounter(int count)
    {
        _countText.text = count.ToString();
    }
}