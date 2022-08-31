
using UnityEngine;

public class player_movement : MonoBehaviour
{
   
   
    
    public Rigidbody rb;    // Start is called before the first frame update
    public float speed =200f;
    public float move =200f;
    // Update is called once per frame
    void FixedUpdate()
    {
        

            rb.AddForce(0, 0, speed * Time.deltaTime);
            if (Input.GetKey("d"))
            {
                rb.AddForce(move * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce((0 - move) * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (rb.position.y < -1)
            {

                FindObjectOfType<gameManager>().EndGame();
            }
           
        
        
    }
   
}
