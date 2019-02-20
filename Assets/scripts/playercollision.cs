
using UnityEngine;

public class playercollision : MonoBehaviour {



    public playermovements movement;
 
    void OnCollisionEnter(Collision collisioninfo)
    {
        //  Debug.Log(collisioninfo.collider.name);//return to console if we hit something
        if (collisioninfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<Game_Manager>().endgame();

        }

    }
}
