using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioClip[] ayakSesleriClips;
    public AudioSource audioSource;
    public CharacterController cc;
    public float ayaksesiBekleme;
    public float ayaksesiOrani;
    private float sonayaksesiZamani;

    private void FixedUpdate()
    {
        if(cc.velocity.magnitude > ayaksesiBekleme)
        {
            if(Time.time - sonayaksesiZamani > ayaksesiOrani)
            {
                sonayaksesiZamani = Time.time;
                audioSource.PlayOneShot(ayakSesleriClips[Random.Range(0,ayakSesleriClips.Length)]);
            }
        }
    }

}
