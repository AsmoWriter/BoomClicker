using UnityEngine;
using UnityEngine.UI;

public class HPCounterUpdateView : MonoBehaviour
{
    [SerializeField]
    private Text _countText;
    [SerializeField]
    private HPCounterScriptableObject _counterScriptableObject;
    [SerializeField]
    private GameObject GameOverCanvas;

    private void Awake()
    {
        _counterScriptableObject.UpdateHP += UpdateCounter;
    }

    private void OnEnable()
    {
        UpdateCounter(_counterScriptableObject.Count);
    }

    private void UpdateCounter(int count)
    {
        _countText.text = count.ToString();
    }
    private void FixedUpdate()
    {
        if (_counterScriptableObject.Count <= 0)
        {
            GameOverCanvas.SetActive(true);
        }
    }
}