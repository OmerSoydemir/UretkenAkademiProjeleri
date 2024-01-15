using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawnerr : MonoBehaviour
{
    public GameObject objectToSpawn;
    private NewBehaviourScript newBehaviourScript;
    
    void Start()
    {
        newBehaviourScript = FindAnyObjectByType<NewBehaviourScript>();
    }

    
    void Update()
    {
        if(Input.touchCount>0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(objectToSpawn,newBehaviourScript.transform.position,newBehaviourScript.transform.rotation);
        }
    }
}
