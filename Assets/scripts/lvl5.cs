using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class lvl5 : MonoBehaviour {

    public void startgamelvl5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);

    }
}
