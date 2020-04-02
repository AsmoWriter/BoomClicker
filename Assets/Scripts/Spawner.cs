using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab;
    [SerializeField]
    private float _interval;

    private float FromX = -14 / 2;
    private float ToX = 14 / 2;

    private float FromY = -8 / 2;
    private float ToY = 8 / 2;

    private Coroutine _spawnRoutine;

    private void OnEnable()
    {
        _spawnRoutine = StartCoroutine(SpawnRoutine);
    }

    private void OnDisable()
    {
        if (_spawnRoutine != null)
            StopCoroutine(_spawnRoutine);
        _spawnRoutine = null;
    }

    private IEnumerator SpawnRoutine
    {
        get
        {
            yield return new WaitForSeconds(_interval);
            while (true)
            {
                Instantiate(_prefab, new Vector3 (Random.Range(FromX, ToX), Random.Range(FromY, ToY), 1), Quaternion.identity);
                yield return new WaitForSeconds(_interval);
            }
        }
    }
}
