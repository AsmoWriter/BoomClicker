using UnityEngine;

public class ModeControl : MonoBehaviour
{
    [SerializeField]
    private GameObject _hud;
    [SerializeField]
    private CounterScriptableObject _counterScriptableObject;
    [SerializeField]
    private GameObject _gameOverWindow;
    [SerializeField]
    private GameObject[] _spawners; 

    private void FixedUpdate()
    {
        if (_counterScriptableObject.Count <= 0)
        {
            _hud.SetActive(false);
            foreach (GameObject spawner in _spawners)
            {
                spawner.SetActive(false);
            }
            _gameOverWindow.SetActive(true);
        }
    }
}
