using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAudio : MonoBehaviour
{
    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            collectionSoundEffect.Play();
        }
    }
}