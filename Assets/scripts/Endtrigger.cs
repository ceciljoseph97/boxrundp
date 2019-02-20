using UnityEngine;

public class Endtrigger : MonoBehaviour {
    public Game_Manager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        gameManager.completelevel();
    }


}
