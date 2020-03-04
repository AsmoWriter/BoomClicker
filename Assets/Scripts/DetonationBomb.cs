using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetonationBomb : MonoBehaviour
{
    [SerializeField]
    float GrowToBoom;
    [SerializeField]
    GameObject ExplosionPrefab;
    private void FixedUpdate()
    {
        if (transform.localScale.x > GrowToBoom)
        {
            Instantiate(ExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        

    }
}
