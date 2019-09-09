using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {

    public void startgame()
    {//refresh menu after every run of this script
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
