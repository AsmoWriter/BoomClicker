using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuStartGame : MonoBehaviour
{
    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("MineScene", LoadSceneMode.Single);
    }
}