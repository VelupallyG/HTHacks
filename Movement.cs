using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    

   
    // Update is called once per frame
    void FixedUpdate()
    {

        if(Input.GetKey("d")){
            rb.AddForce(500 *Time.deltaTime,0,0);
        }

        if(Input.GetKey("a")){
            rb.AddForce(-500 *Time.deltaTime,0,0);
        }

        if(rb.position.y < -1f){
             Destroy(this.gameObject);
        }
    }
}
