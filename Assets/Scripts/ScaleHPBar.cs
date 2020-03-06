using UnityEngine;

public class ScaleHpBar : MonoBehaviour
{
    [SerializeField]
    private HPCounterScriptableObject _counterScriptableObject;

    private float MaxHP = 100;

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
        transform.localScale = new Vector3(count / MaxHP, 1, 1);
    }
}
