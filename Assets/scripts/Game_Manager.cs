using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    bool gamehasended = false;
    public float restartdelay = 1f;
    public GameObject completelevelui,pauseButton;
    public void completelevel()
    {
        pauseButton.SetActive(false);
        Debug.Log("Level Won");
        completelevelui.SetActive(true);
    }
    public void endgame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("!!!GAME OVER!!!");
            //restarting the game
            
               Invoke("restart", restartdelay);
        }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}