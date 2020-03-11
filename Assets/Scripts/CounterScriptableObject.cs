using System;

using UnityEditor;
using UnityEngine;


public class CounterScriptableObject : ScriptableObject
{
    [SerializeField]
    private int _count = 0;
    [SerializeField]
    private int _baseCount;

    public int Count => _count;

    [SerializeField]
    private bool _resetOnNewGame = true;

    public event Action<int> UpdateValue;
    public void OnEnable()
    {
        if (_resetOnNewGame)
        {
            _count = _baseCount;
        }
    }

    public void ChangeValue(int count)
    {
        _count += count;
        UpdateValue?.Invoke(_count);
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
