using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HareketEtme : MonoBehaviour
{
    public float hiz = 3f;
    bool aktifMi = false;
    
    void Update()
    {


        Vector3 playerInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 devamliHareket = playerInput * hiz * Time.deltaTime;
        transform.Translate(devamliHareket);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (aktifMi==false)
            {
                hiz = 7f;
                aktifMi = true;
            }
            else
            {
                hiz = 3f;
                aktifMi = false;
            }
        }
        

    }
}
