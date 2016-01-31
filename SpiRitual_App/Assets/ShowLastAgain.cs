using UnityEngine;
using System.Collections;

public class ShowLastAgain : MonoBehaviour {

    // Use this for initialization
    void OnMouseUp()
    {
        if (CardUI.TheCardUI.isActiveAndEnabled)
            return;

        ShowCard();
    }

    void ShowCard()
    {
        CardUI.TheCardUI.ShowPrevious();
        BossToggle.TheBossToggle.Reset();
    }
}
