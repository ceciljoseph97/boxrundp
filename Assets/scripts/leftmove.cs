using UnityEngine;

public class leftmove : MonoBehaviour {
    public Rigidbody rb;
    public float forwardforce = 2000f;//for fconstant forward force
    public float sidewaysforce = 500f;//for moving right 
    public void moveleft()
    {


        rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);//for rightside

    }
}
