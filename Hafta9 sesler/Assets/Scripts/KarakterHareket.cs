using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareket : MonoBehaviour
{

    public float moveSpeed;
    public CharacterController characterController;
    public Transform cam;
    public float lookSens;
    public float maxXRot;
    public float minXRot;
    private float curXRot;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        Move();
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            Look();
            
        }
        
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 dir = transform.right * x + transform.forward * z;
        dir.Normalize();

        dir *= moveSpeed * Time.deltaTime;
        characterController.Move(dir);
    }
    void Look()
    {
        float x = Input.GetAxis("Mouse X") * lookSens;
        float y = Input.GetAxis("Mouse Y") * lookSens;

        transform.eulerAngles += Vector3.up * x;

        curXRot += y;
        curXRot = Mathf.Clamp(curXRot, minXRot, maxXRot);
        cam.localEulerAngles = new Vector3(-curXRot, 0, 0);
    }
}
