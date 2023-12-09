using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TntExplode : MonoBehaviour
{
    private Animator anim;
    public AudioSource audioSource;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            Explode();
    }

    public void Explode()
    {
        
        audioSource.Play();
        anim.SetTrigger("explode");

    }

}
