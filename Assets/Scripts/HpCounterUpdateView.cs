using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpCounterUpdateView : MonoBehaviour
{
    [SerializeField]
    private Text _countText;
    [SerializeField]
    private HpCountScriptableObject _counterScriptableObject;

    private void Awake()
    {
        _counterScriptableObject.UpdateHealth += UpdateCounter;
    }

    private void OnEnable()
    {
        UpdateCounter(_counterScriptableObject.Count);
    }

    private void UpdateCounter(int count)
    {
        if (count <= 0)
        {
            SceneManager.LoadScene("GameOverScene", LoadSceneMode.Single);
        }
        _countText.text = "HP: "+count.ToString()+"%";
    }
}
