using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit_Button : MonoBehaviour
{
    public GameObject Pause_UI;
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Time.timeScale = 0;
            Pause_UI.SetActive(true);
        }

    }
}
