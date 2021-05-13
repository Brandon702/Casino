using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

using static Suit;
using static Face;

public enum Suit
{
    Clubs,
    Spades,
    Diamonds,
    Hearts
}
public enum Face
{
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
    Ace
}

public class Card : MonoBehaviour
{
    public Suit Suit { get; }
    public Face Face { get; }
    public int Value { get; set; }
    public int Symbol { get; }

    public Card(Suit suit, Face face)
    {
        Suit = suit;
        Face = face;

        switch (Suit)
        {
            case Clubs:
                Symbol = 0;
                break;
            case Spades:
                Symbol = 1;
                break;
            case Diamonds:
                Symbol = 2;
                break;
            case Hearts:
                Symbol = 3;
                break;
        }
        switch (Face)
        {
            case Ten:
            case Jack:
            case Queen:
            case King:
                Value = 10;
                break;
            case Ace:
                Value = 11;
                break;
            default:
                Value = (int)Face + 1;
                break;
        }
    }
}