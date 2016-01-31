using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DeckScript : MonoBehaviour {
    
    public string DeckName;
    public Sprite DeckImage;
    public Sprite BossBG;
    public Sprite NormalBG;
    
    public List<Card> cards;

	// Use this for initialization
	void OnMouseUp () {
        if (CardUI.TheCardUI.isActiveAndEnabled)
            return;

        ShowCard();
	}
	
    void ShowCard()
    {
        CardUI.TheCardUI.ShowCard(SelectCard(), DeckImage, NormalBG, BossBG, BossToggle.TheBossToggle.IsBossEncounter);
        BossToggle.TheBossToggle.Reset();
    }

    Card SelectCard()
    {
        if(cards.Count ==0)
        {
            Debug.LogWarning("No cards left in this deck");
            return null;
        }
        return cards[Random.Range(0, cards.Count)];
    }

}
