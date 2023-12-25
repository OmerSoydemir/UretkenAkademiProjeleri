using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public GameObject panel;
    public Text text;
    int sayac = 5;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Gorev")
        {
            Destroy(collision.gameObject);
            sayac--;

            text.text = "Trafik dubalarýný topla ve oyunu kazan \n Kalan Duba sayýsý :" + sayac;
        }

        if (sayac == 0)
        {
            panel.SetActive(true);
        }
    }
   
}
