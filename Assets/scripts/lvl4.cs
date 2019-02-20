using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class lvl4 : MonoBehaviour {

    public void startgamelvl4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);

    }
}
