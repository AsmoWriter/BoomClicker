using UnityEngine;

public class BombGrow : MonoBehaviour
{
    private Vector3 _growSize = new Vector3(1, 1, 1);

    [SerializeField]
    private float _growSpeed;

    private void FixedUpdate()
    {
        transform.localScale += _growSize * Time.deltaTime * _growSpeed;
    }
}
