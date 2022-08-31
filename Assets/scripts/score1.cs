
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class score1 : MonoBehaviour
{
    
    public Transform player;
    public Text scoreInfo;

    void FixedUpdate() {
     float z = player.position.z;
     int scor_e= (int)z;
     
     scoreInfo.text = scor_e.ToString(); 
       
      
    }
  
}
