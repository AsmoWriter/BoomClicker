using UnityEngine;
using UnityEngine.UI;

public class HpCounterUpdateView : MonoBehaviour
{
    [SerializeField]
    private Text _countText;
    [SerializeField]
    private HpCountScriptableObject _counterScriptableObject;
    [SerializeField]
    private GameObject GameOver;

    private void Awake()
    {
        _counterScriptableObject.UpdateHealth += UpdateCounter;
    }

    private void OnEnable()
    {
        UpdateCounter(_counterScriptableObject.Count);
    }

    private void UpdateCounter(int count)
    {
        if (count <= 0)
        {
            GameOver.SetActive(true);
        }
        _countText.text = "HP: "+count.ToString()+"%";
    }
}
