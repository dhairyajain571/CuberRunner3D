using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    public void Switchcam()
    {
      if (cam1.active == true)
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
        else if (cam1.active == false)
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
    }
    
}
