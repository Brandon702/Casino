using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public int value = 0;

    public int GetValueOfCard()
    {
        return value;
    }

    public void SetValue(int newValue)
    {
        value = newValue;
    }
    
    public void SetSprite(Sprite newSprite)
    {
        gameObject.GetComponent<Image>().sprite = newSprite;
    }

    public string GetSpriteName()
    {
        return GetComponent<Image>().sprite.name;
    }

    public void ResetCard()
    {
        Sprite back = GameObject.Find("Deck").GetComponent<Deck>().GetCardBack();
        gameObject.GetComponent<Image>().sprite = back;
        value = 0;
    }
}
