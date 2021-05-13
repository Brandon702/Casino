using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Deck : MonoBehaviour
{
    private List<Card> cards;

    public Deck()
    {
        Initialize();
    }

    public List<Card> GetDeck()
    {
        List<Card> deck = new List<Card>();

        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                deck.Add(new Card((Suit)j, (Face)i));
            }
        }
        return deck;
    }

    public List<Card> DealHand()
    {
        List<Card> hand = new List<Card>();
        hand.Add(cards[0]);
        hand.Add(cards[1]);

        cards.RemoveRange(0, 2);

        return hand;
    }

    public Card DrawCard()
    {
        Card card = cards[0];
        cards.Remove(card);

        return card;
    }

    public void Shuffle()
    {
        System.Random rng = new System.Random();

        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Card card = cards[k];
            cards[k] = cards[n];
            cards[n] = card;
        }
    }

    public void Initialize()
    {
        cards = GetDeck();
        Shuffle();
    }
}