using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;
public class SesKontrol : MonoBehaviour
{
    public AudioMixer mixer;
    public GameObject pencere;
    public Slider masterSlider;
    public Slider MusicSlider;
    public Slider SFXSlider;


    void SliderAyar()
    {

        masterSlider.value = PlayerPrefs.GetFloat("MasterVolume");
        MusicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume");
    }

    private void Start()
    {
        if (PlayerPrefs.HasKey("MasterVolume"))
        {
            mixer.SetFloat("MasterVolume", PlayerPrefs.GetFloat("MasterVolume"));
            mixer.SetFloat("SFXVolume", PlayerPrefs.GetFloat("SFXVolume"));
            mixer.SetFloat("MusicVolume", PlayerPrefs.GetFloat("MusicVolume"));
            SliderAyar();
        }
        else
        {
            SliderAyar();
        }
        
    }
    public void UpdateMasterVolume()
    {
        mixer.SetFloat("MasterVolume", masterSlider.value);
        PlayerPrefs.SetFloat("MasterVolume", masterSlider.value);
    }
    public void UpdateSFXVolume()
    {
        mixer.SetFloat("SFXVolume", SFXSlider.value);
        PlayerPrefs.SetFloat("SFXVolume", SFXSlider.value);
    }
    public void UpdateMusicVolume()
    {
        mixer.SetFloat("MusicVolume", MusicSlider.value);
        PlayerPrefs.SetFloat("MusicVolume", MusicSlider.value);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            pencere.SetActive(!pencere.activeInHierarchy);

            if(pencere.activeInHierarchy )
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else 
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

}
