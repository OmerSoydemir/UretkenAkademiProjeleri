using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yürüme : MonoBehaviour
{
    public float hiz = 2f;
    public Animator animator;
   
    void Update()
    {
        Vector3 hareket = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 hizeklentisi = hareket * Time.deltaTime * hiz;
        transform.Translate(hizeklentisi);

        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
