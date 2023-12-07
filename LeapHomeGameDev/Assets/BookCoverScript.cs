using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookCoverScript : MonoBehaviour
{
    public GameObject bookCoverFlip;

    private void OnMouseEnter()
    {
        bookCoverFlip.SetActive(true);
    }

    private void OnMouseExit()
    {
        bookCoverFlip.SetActive(false);
    }
}
