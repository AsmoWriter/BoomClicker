using UnityEngine;

public class ScaleHpBar : MonoBehaviour
{
    [SerializeField]
    private CounterScriptableObject _hpCounterScriptableObject;

    private float MaxHP = 100;

    private void Awake()
    {
        _hpCounterScriptableObject.UpdateValue += UpdateCounter;
    }

    private void OnEnable()
    {
        UpdateCounter(_hpCounterScriptableObject.Count);
    }
    private void UpdateCounter(int count)
    {
        transform.localScale = new Vector3(count / MaxHP, 1, 1);
        if (count <= 0)
        {
            _hpCounterScriptableObject.UpdateValue -= UpdateCounter;
        }
    }
}
