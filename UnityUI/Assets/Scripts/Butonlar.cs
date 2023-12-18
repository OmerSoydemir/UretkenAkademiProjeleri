using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Butonlar : MonoBehaviour
{
   public void CikisButonu()
    {
        Application.Quit();
    }
    public void GirisButonu()
    {
        SceneManager.LoadScene(1);    
    }
    public void ilkSahneyeDonus()
    {
        SceneManager.LoadScene(0);

    }


}
