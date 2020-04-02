using System;
using UnityEditor;
using UnityEngine;


public class CounterScriptableObject : ScriptableObject
{
    [SerializeField]
    private int _count = 0;
    [SerializeField]
    private int _baseCount;

    public int PriorCount;

    public int Count => _count;

    [SerializeField]
    private bool _resetOnNewGame = true;

    public event Action<int> UpdateValue;
    public void OnEnable()
    {
        ResetValue();
    }

    public void ChangeValue(int count)
    {
        _count += count;
        UpdateValue?.Invoke(_count);
    }

    public void ResetValue()
    {
        if (_resetOnNewGame)
        {
            PriorCount = _count;
            _count = _baseCount;
            UpdateValue?.Invoke(_count);
        }
    }

#if UNITY_EDITOR
    [MenuItem("Assets/Create/CounterScriptableObject")]
    public static void CreateMyAsset()
    {
        CounterScriptableObject asset = CreateInstance<CounterScriptableObject>();
        AssetDatabase.CreateAsset(asset, "Assets/Counters/NewCounterScriptableObject.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
#endif
}
