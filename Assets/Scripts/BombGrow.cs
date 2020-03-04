using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGrow : MonoBehaviour
{
    private Vector3 GrowSize = new Vector3(1, 1, 1);

    [SerializeField]
    float GrowSpeed;

    private void FixedUpdate()
    {
        transform.localScale += GrowSize * Time.deltaTime * GrowSpeed;
    }
}
