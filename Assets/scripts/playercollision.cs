using UnityEngine;

public class playercollision : MonoBehaviour
{
    
    public player_movement moveinfo;
    void OnCollisionEnter(Collision info) {
       
     if(info.collider.tag == "obstacle")
     {
            moveinfo.enabled = false;
            FindObjectOfType<gameManager>().EndGame();
     }

     
   }
}
