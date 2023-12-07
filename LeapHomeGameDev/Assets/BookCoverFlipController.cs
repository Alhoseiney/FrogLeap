using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCoverFlipController : MonoBehaviour
{
    public GameObject bookCoverOpen;
    public SpriteRenderer spriteRenderer;

    private Sprite originalSprite;

    private void Start()
    {
        originalSprite = spriteRenderer.sprite;
    }

    private void OnMouseDown()
    {
        spriteRenderer.sprite = bookCoverOpen.GetComponent<SpriteRenderer>().sprite;
    }
}
