using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class ScoreCounterScriptableObject : ScriptableObject
{
    [SerializeField]
    private int _count = 0;

    public int Count => _count;
    [SerializeField]
    private bool _resetOnNewGame = true;

    public event Action<int> UpdateScore;
    public void OnEnable()
    {
        if (_resetOnNewGame)
        {
            _count = 0;
        }
    }

    public void AddValue(int count)
    {
        _count += count;
        UpdateScore?.Invoke(_count);
    }

#if UNITY_EDITOR
    [MenuItem("Assets/Create/ScoreCounterScriptableObject")]
    public static void CreateMyAsset()
    {
        ScoreCounterScriptableObject asset = CreateInstance<ScoreCounterScriptableObject>();
        AssetDatabase.CreateAsset(asset, "Assets/Counters/NewScoreCounterScriptableObject.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
#endif
}
