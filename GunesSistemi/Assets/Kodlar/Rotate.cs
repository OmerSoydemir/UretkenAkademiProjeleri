using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector3 yon;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(yon);
    }
}
