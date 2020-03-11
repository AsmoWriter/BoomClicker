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
    private CounterScriptableObject HP;
    [SerializeField]
    private int Damage;

    private void FixedUpdate()
    {
        if (transform.localScale.x > _GrowToBoom)
        {
            Instantiate(ExplosionPrefab, transform.position, Quaternion.identity);
            HP.ChangeValue(-Damage);
            Destroy(gameObject);
        }
    }
}
