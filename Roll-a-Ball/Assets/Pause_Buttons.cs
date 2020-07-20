using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Buttons : MonoBehaviour
{
    public GameObject Pause_UI;
    public void Resume()
    {
        Time.timeScale = 1;
        Pause_UI.SetActive(false);
    }

    public void GoMenu()
    {
        Pause_UI.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
