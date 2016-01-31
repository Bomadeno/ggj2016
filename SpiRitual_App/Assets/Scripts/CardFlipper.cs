using UnityEngine;
using System.Collections;
using System;

public class CardFlipper : MonoBehaviour
{
    public GameObject Front;
    public GameObject Back;

    void Start()
    {
        if (Front == null || Back == null)
        {
            Debug.LogError("You need to attach the Front and Back " +
                 "GameObjects to the CardFlipper component in editor");
        }
        Front.SetActive(true);
        Back.SetActive(false);
    }

    void OnMouseDown()
    {
        FlipCard();
    }

    private void FlipCard()
    {
        if (Front.activeSelf)
        {
            Front.SetActive(false);
            Back.SetActive(true);
        }
        else if (Back.activeSelf)
        {
            Back.SetActive(false);
            Front.SetActive(true);
        }
    }
}
