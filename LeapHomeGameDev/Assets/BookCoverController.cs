using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCoverController : MonoBehaviour
{
    public GameObject bookCoverFlip;
    public SpriteRenderer spriteRenderer;

    private Sprite originalSprite;

    private void Start()
    {
        originalSprite = spriteRenderer.sprite;
    }

    private void OnMouseEnter()
    {
        spriteRenderer.sprite = bookCoverFlip.GetComponent<SpriteRenderer>().sprite;
    }

    private void OnMouseExit()
    {
        spriteRenderer.sprite = originalSprite;
    }
}
