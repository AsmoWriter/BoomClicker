using UnityEngine;

public class DeletAnimation : MonoBehaviour
{
    [SerializeField]
    private float _intervalToDelet;


    private void FixedUpdate()
    {
        _intervalToDelet -= Time.fixedDeltaTime;

        if (_intervalToDelet <= 0)
        {
            Destroy(gameObject);
        }
    }
}
