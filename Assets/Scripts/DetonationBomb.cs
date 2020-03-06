using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetonationBomb : MonoBehaviour
{
    [SerializeField]
    float _GrowToBoom = 7;
    [SerializeField]
    public GameObject ExplosionPrefab;
    [SerializeField]
    private HPCounterScriptableObject HP;
    [SerializeField]
    private int Damage;

    private void FixedUpdate()
    {
        if (transform.localScale.x > _GrowToBoom)
        {
            Instantiate(ExplosionPrefab, transform.position, Quaternion.identity);
            HP.AddValue(Damage);
            Destroy(gameObject);
        }
    }
}
