using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
   public void CikisButonu()
    {
        Application.Quit();
    }
    public void OyunaGecis()
    {
        SceneManager.LoadScene(1);
    }
    public void YenidenOyna()
    {
        SceneManager.LoadScene(1);
    }
    public void SonrakiBolum()
    {
        SceneManager.LoadScene(2);
    }
}
