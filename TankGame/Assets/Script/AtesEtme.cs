using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AtesEtme : MonoBehaviour
{
    RaycastHit hit;
    
    
    
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(Camera.main.transform.position,transform.forward, out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.tag == "dusman")
                {
                    Destroy(hit.collider.gameObject);
                    
                    
                }
            }
        }
       
    }
}
