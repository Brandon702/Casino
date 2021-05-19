using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public Card cardScript;
    public Deck deckScript;

    public int handValue = 0;
    private int money = 1000;
    public GameObject[] hand;
    public int cardIndex = 0;

    List<Card> aceList = new List<Card>();

    public void StartHand()
    {
        GetCard();
        GetCard();
    }

    public int GetCard()
    {
        int cardValue = deckScript.DealCard(hand[cardIndex].GetComponent<Card>());
        hand[cardIndex].GetComponent<Renderer>().enabled = true;
        handValue += cardValue;

        if(cardValue == 1)
        {
            aceList.Add(hand[cardIndex].GetComponent<Card>());
        }
        AceCheck();
        cardIndex++;
        return cardValue;
    }

    public void AceCheck()
    {
        foreach(Card ace in aceList)
        {
            if (handValue + 10 < 22 && ace.GetValueOfCard() == 1)
            {
                ace.SetValue(11);
                handValue += 10;
            }
            else if (handValue > 21 && ace.GetValueOfCard() == 11)
            {
                ace.SetValue(1);
                handValue -= 10;
            }
        }
    }

    public void AdjustMoney(int amount)
    {
        money += amount;
    }

    public int GetMoney()
    {
        return money;
    }

    public void ResetHand()
    {
        for (int i = 0; i < hand.Length; i++)
        {
            hand[i].GetComponent<Card>().ResetCard();
            hand[i].GetComponent<Renderer>().enabled = false;
        }
        cardIndex = 0;
        handValue = 0;
        aceList = new List<Card>();
    }
}
