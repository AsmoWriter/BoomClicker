using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    GameObject Prefab;

    [SerializeField]
    float Interval;

    private float _timer;

    private void FixedUpdate()
    {
        _timer -= Time.fixedDeltaTime;

        if (_timer > 0)
            return;

        _timer += Interval;
        Instantiate(Prefab, transform.position, Quaternion.identity);
    }
}
