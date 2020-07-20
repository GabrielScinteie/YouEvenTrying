using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Main_Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MiniGame", LoadSceneMode.Single);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
