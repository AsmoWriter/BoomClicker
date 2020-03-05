using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleHPBar : MonoBehaviour
{
    [SerializeField]
    private HpCountScriptableObject _counterScriptableObject;

    private float MaxHP = 100;

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
        transform.localScale = new Vector3(count/MaxHP, 1, 1);
    }
}
