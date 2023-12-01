using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject flashLight;
    private bool acikMi;
    void Start()
    {

        acikMi = true;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            {
            if (acikMi)
            {
                flashLight.GetComponent<Light>().enabled = false;
                acikMi = false;
            }
            else
            {
                flashLight.GetComponent<Light>().enabled = true;
                acikMi = true;
            }
            

        }
        
    }
}
