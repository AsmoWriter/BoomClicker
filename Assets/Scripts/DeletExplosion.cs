using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletExplosion : MonoBehaviour
{
    [SerializeField]
    float IntervalToDelet;


    private void FixedUpdate()
    {
        IntervalToDelet -= Time.fixedDeltaTime;

        if (IntervalToDelet <= 0)
        {
            Destroy(gameObject);
        }
    }
}
