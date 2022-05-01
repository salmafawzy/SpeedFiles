using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCollision : MonoBehaviour
{
    public GameObject ENDUI;
   
    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Car")
        {
            ENDUI.SetActive(true); 
        }
    }
}
