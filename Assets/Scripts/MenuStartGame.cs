using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStartGame : MonoBehaviour
{
    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("MineScene", LoadSceneMode.Single);
    }
}