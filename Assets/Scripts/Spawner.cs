using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab;
    [SerializeField]
    private float _interval;

    private float FromX = -16 / 2;
    private float ToX = 16 / 2;

    private float FromY = -10 / 2;
    private float ToY = 10 / 2;

    private float _timer;

    private void FixedUpdate()
    {
        _timer -= Time.fixedDeltaTime;

        if (_timer > 0)
            return;

        _timer += _interval;
        Instantiate(_prefab, new Vector3(Random.Range(FromX, ToX), Random.Range(FromY, ToY), 1), Quaternion.identity);
    }
}
