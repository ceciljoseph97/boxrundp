using UnityEngine;

public class playermovements : MonoBehaviour {



    public Rigidbody rb;
    public float forwardforce = 2000f;//for fconstant forward force
    public float sidewaysforce = 500f;//for moving right and left
   
    
    // Use this for initialization

    // Update is called once per frame
    //changed to FixedUpdate for more efficient reaction to physics;
    void FixedUpdate () {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);


        //if statement

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);//for rightside
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);// for leftside
        }
       
        if (rb.position.y < -1f)
        {
            FindObjectOfType<Game_Manager>().endgame();
        }

    }
}
