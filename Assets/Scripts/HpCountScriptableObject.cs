using System;
using UnityEditor;
using UnityEngine;

public class HpCountScriptableObject : ScriptableObject
{
    [SerializeField]
    private int _count = 100;

    public int Count => _count;
    [SerializeField]
    private bool _resetOnNewGame = true;

    public event Action<int> UpdateHealth;
    public void OnEnable()
    {
        if (_resetOnNewGame)
        {
            _count = 100;
        }
    }

    public void AddValue(int count)
    {
        _count -= count;
        UpdateHealth?.Invoke(_count);
    }

#if UNITY_EDITOR
    [MenuItem("Assets/Create/HPCounterScriptableObject")]
    public static void CreateMyAsset()
    {
        HpCountScriptableObject asset = CreateInstance<HpCountScriptableObject>();
        AssetDatabase.CreateAsset(asset, "Assets/Counters/NewHPCounterScriptableObject.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
#endif
}
