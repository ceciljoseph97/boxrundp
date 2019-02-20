using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class backtomenucredits : MonoBehaviour {

    public void backtomaincredits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);

    }
}
