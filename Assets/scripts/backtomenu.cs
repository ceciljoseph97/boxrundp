using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class backtomenu : MonoBehaviour {

    public void backtomain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);

    }
}
