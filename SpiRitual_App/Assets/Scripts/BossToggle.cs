using UnityEngine;
using System.Collections;

public class BossToggle : MonoBehaviour {
    public static BossToggle TheBossToggle;
    public bool IsBossEncounter;
    public TextMesh TextMesh;

    void Awake()
    {
        TheBossToggle = this;
        Reset();
    }

    internal void Reset()
    {
        IsBossEncounter = false;
        UpdateAppearance();
    }

    void OnMouseUp() { 
    
        if (CardUI.TheCardUI.isActiveAndEnabled)
            return;

        IsBossEncounter = !IsBossEncounter;

        UpdateAppearance();
    }

    void UpdateAppearance()
    {
        if (IsBossEncounter)
        {
            TextMesh.text = "Boss: YES";
        }
        else
        {
            TextMesh.text = "Boss: NO";
        }
    }
}
