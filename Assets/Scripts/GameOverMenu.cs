using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{
    public void OnRestartButtonClick()
    {
        SceneManager.LoadScene("MineScene", LoadSceneMode.Single);
    }

    public void OnMenuButtonClick()
    {
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
    }
}
