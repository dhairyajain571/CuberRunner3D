using UnityEngine;

public class levelWon : MonoBehaviour
{
    
    void OnCollisionEnter(Collision info)
    {

        if (info.collider.tag == "Player")
        {
            
            FindObjectOfType<gameManager>().levelWon();
        }


    }
}
