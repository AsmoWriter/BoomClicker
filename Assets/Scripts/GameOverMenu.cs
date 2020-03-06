using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void OnMenuButtonClick()
    {
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
    }
}
