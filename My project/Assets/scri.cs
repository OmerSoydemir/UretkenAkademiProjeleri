using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scri : MonoBehaviour
{
    public static void bolenleriBulma(int sayi1, int sayi2)
    {
        List<int> t�mSayilar = new List<int>();
        List<int> ikiyeBolunenler = new List<int>();
        List<int> uceBolunenler = new List<int>();
        List<int> dordeBolunenler = new List<int>();
        List<int> beseBolunenler = new List<int>();

        for (int i = sayi1; i <= sayi2; i++)
        {
            t�mSayilar.Add(i);
            if (i % 2 == 0)
            {
                ikiyeBolunenler.Add(i);
            }
            if (i % 3 == 0)
            {
                uceBolunenler.Add(i);
            }
            if (i % 4 == 0)
            {
                dordeBolunenler.Add(i);
            }
            if (i % 5 == 0)
            {
                beseBolunenler.Add(i);
            }
        }
        print("T�m Say�lar: " + string.Join(", ", t�mSayilar));
        print("2'ye b�l�nebilen say�lar: " +string.Join(", ", ikiyeBolunenler));
        print("3'e b�l�nebilen say�lar: " + string.Join(", ", uceBolunenler));
        print("4'e b�l�nebilen say�lar: " + string.Join(", ", dordeBolunenler));
        print("5'e b�l�nebilen say�lar: " + string.Join(", ", beseBolunenler));
    }



    void Start()
    {
        bolenleriBulma(1, 10);
    }

    
  
}
