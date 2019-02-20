using UnityEngine;

public class rightmove : MonoBehaviour {
    public Rigidbody rb;
    public float forwardforce = 2000f;//for fconstant forward force
    public float sidewaysforce = 500f;//for moving right 
    public void moveright()
    {
       
        
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);//for rightside
        
    }

}
