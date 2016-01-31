using UnityEngine;
using System.Collections;

public class CardUI : MonoBehaviour {

    public static CardUI TheCardUI;
    public UnityEngine.UI.Image IconImageRenderer;
    public UnityEngine.UI.Text DescriptionTarget;
    public UnityEngine.UI.Text GoodStuffTarget;
    public UnityEngine.UI.Text BadStuffTarget;
    public UnityEngine.UI.Text HitPointText;
    public UnityEngine.UI.Text BossInfo;
    public UnityEngine.UI.Image BossImageRenderer;
    public UnityEngine.UI.Image CardBackground;


    void Awake() {
        TheCardUI = this;
        gameObject.SetActive(false);
	}


    public void OnMouseDown()
    {
        gameObject.SetActive(false);
    }

    internal void ShowPrevious()
    {
        gameObject.SetActive(true);
    }

    internal void ShowCard(Card cardToShow, Sprite deckSprite, Sprite backGroundSprite, Sprite bossSprite, bool IsBossEncounter)
    {
        BossInfo.gameObject.SetActive(IsBossEncounter);
        BossImageRenderer.sprite = bossSprite;
        BossImageRenderer.gameObject.SetActive(IsBossEncounter);
        IconImageRenderer.sprite = deckSprite;
        CardBackground.sprite = backGroundSprite;
        if (cardToShow != null)
        {
            DescriptionTarget.text = cardToShow.CardDescription;
            string goodStuff = "<b>Success:</b>\n";
            foreach (var thing in cardToShow.Rewards)
            {
                goodStuff += thing + "\n";
            }
            GoodStuffTarget.text = goodStuff;

            string badStuff = "<b>Failure:</b>\n";
            foreach (var thing in cardToShow.Punishments)
            {
                badStuff += thing + "\n";
            }
            BadStuffTarget.text = badStuff;

            HitPointText.text = ""+cardToShow.Hitpoints;
        }
        else
        {
            DescriptionTarget.text = "Plaiceholder";
            GoodStuffTarget.text = "Good stuff:\nPlaiceholder!";
            BadStuffTarget.text = "Bad stuff:\nPlaiceholder!";
            HitPointText.text = "0";
        }

        gameObject.SetActive(true);
    }
}
