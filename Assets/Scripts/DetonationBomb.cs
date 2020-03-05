using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetonationBomb : MonoBehaviour
{
    [SerializeField]
    private int _HpDamage = 10;
    [SerializeField]
    private HpCountScriptableObject _scoreCounter;
    [SerializeField]
    float _GrowToBoom = 7;
    [SerializeField]
    public GameObject ExplosionPrefab;

    private void FixedUpdate()
    {
        if (transform.localScale.x > _GrowToBoom)
        {
            Instantiate(ExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            _scoreCounter.AddValue(_HpDamage);
        }
        

    }
}
