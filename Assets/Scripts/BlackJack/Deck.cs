using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public Sprite[] cards;
    int[] cardValue = new int[53];
    private int currentIndex = 0;

    private void Start()
    {
        GetCardValues(); 
    }

    private void GetCardValues()
    {
        int num = 0;
        for (int i = 0; i < cards.Length; i++)
        {
            num = i;
            num %= 13;
            if (num > 10 || num == 0)
            {
                num = 10;
            }
            cardValue[i] = num++;
        }
    }

    public void Shuffle()
    {
        for (int i = cards.Length - 1; i > 0; --i)
        {
            int j = Mathf.FloorToInt(UnityEngine.Random.Range(0.0f, 1.0f) * cards.Length - 1) + 1;
            Sprite face = cards[i];
            cards[i] = cards[j];
            cards[j] = face;

            int value = cardValue[i];
            cardValue[i] = cardValue[j];
            cardValue[j] = value;
        }
        currentIndex = 1;
    }

    public int DealCard(Card card)
    {
        card.SetSprite(cards[currentIndex]);
        card.SetValue(cardValue[currentIndex]);
        currentIndex++;
        return card.GetValueOfCard();
    }

    public Sprite GetCardBack()
    {
        return cards[0];
    }
}