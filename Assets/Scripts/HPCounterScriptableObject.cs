using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;


public class HPCounterScriptableObject : ScriptableObject
{
    [SerializeField]
    private int _count = 100;

    public int Count => _count;
    [SerializeField]
    private bool _resetOnNewGame = true;

    public event Action<int> UpdateHP;
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
        UpdateHP?.Invoke(_count);
    }

#if UNITY_EDITOR
    [MenuItem("Assets/Create/HPCounterScriptableObject")]
    public static void CreateMyAsset()
    {
        HPCounterScriptableObject asset = CreateInstance<HPCounterScriptableObject>();
        AssetDatabase.CreateAsset(asset, "Assets/Counters/NewHPCounterScriptableObject.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
#endif
}
