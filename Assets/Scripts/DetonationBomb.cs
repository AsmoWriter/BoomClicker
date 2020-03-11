using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetonationBomb : MonoBehaviour
{
    [SerializeField]
    float _growToBoom = 7;
    [SerializeField]
    private CounterScriptableObject _hp;
    [SerializeField]
    private int _damage;

    public GameObject ExplosionPrefab;

    private void FixedUpdate()
    {
        if (transform.localScale.x > _growToBoom)
        {
            Instantiate(ExplosionPrefab, transform.position, Quaternion.identity);
            _hp.ChangeValue(- _damage);
            Destroy(gameObject);
        }
    }
}
