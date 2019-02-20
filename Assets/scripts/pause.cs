using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pause : MonoBehaviour {
    public GameObject pauseButton, pausePanel;


    public void pausegame()
    {
        pausePanel.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;
    }
    public void unpausegame()
    {
        pausePanel.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1;
    }

    public void backtmenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

}
