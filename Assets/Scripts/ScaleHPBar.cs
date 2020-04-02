using UnityEngine;

public class ScaleHpBar : MonoBehaviour
{
    [SerializeField]
    private CounterScriptableObject _hpCounterScriptableObject;

    private float _maxHP = 100;

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
        transform.localScale = new Vector3(count / _maxHP, 1, 1);
    }
}
