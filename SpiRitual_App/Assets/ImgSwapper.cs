using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class ImgSwapper : MonoBehaviour {

    public List<SpiritAnimal> SpiritAnimals;

	// Use this for initialization
	void Start ()
    {
        SpriteRenderer rend = GetComponent<SpriteRenderer>();
        SpiritAnimal s = SpiritAnimals.Where(x => x.Name.Equals(GameManager.Incoming)).FirstOrDefault();
        if (s != null)
            rend.sprite = s.Img;	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

[System.Serializable]
public class SpiritAnimal
{
    public string Name;
    public Sprite Img;
    
}
