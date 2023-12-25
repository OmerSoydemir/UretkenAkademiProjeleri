using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zıplama : MonoBehaviour
{
    public float jumpForce = 10f;
    public Animator animator;

    private Rigidbody rb;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            
            

        }
        else
        {
            

        }


    }

    void Jump()
    {
        if (Mathf.Abs(rb.velocity.y) < 0.001f) // Karakter yerdeyse
        {
            
            StartCoroutine(ResetJumpAnimation());

        }
    }
    IEnumerator ResetJumpAnimation()
    {
        animator.SetBool("isJumping", true);
       
        yield return new WaitForSeconds(1.5f); // Örnek olarak 0.5 saniye bekleyebilirsiniz.
       // rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        animator.SetBool("isJumping", false);
    }

}

