using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnPosition : MonoBehaviour
{
    // область спавна привязана  к соотношению сторон экрана в числах ниже
    // хотелось бы сделать иначе, но чёт не понял как...
    private float FromX =-16 / 2;
    private float ToX = 16 / 2;

    private float FromY = -10 / 2;
    private float ToY = 10 / 2;

    private void FixedUpdate()
    {
        transform.position = new Vector3(Random.Range(FromX, ToX), Random.Range(FromY, ToY), 1);
    }
}
