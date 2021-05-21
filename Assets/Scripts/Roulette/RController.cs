using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class RController : MonoBehaviour
{
    public Button chip_1;
    public Button chip_5;
    public Button chip_10;
    public Button chip_20;
    public Button chip_50;
    public Button chip_100;
    public Button chip_500;
    public Button chip_1000;
    public Button chip_5000;
    public TMP_Text betValue;
    public TMP_Text chipsValue;
    public Button spin;


    public void Start()
    {
        chip_1.onClick.AddListener(() => chipClicked(chip_1));
        chip_5.onClick.AddListener(() => chipClicked(chip_5));
        chip_10.onClick.AddListener(() => chipClicked(chip_10));
        chip_20.onClick.AddListener(() => chipClicked(chip_20));
        chip_50.onClick.AddListener(() => chipClicked(chip_50));
        chip_100.onClick.AddListener(() => chipClicked(chip_100));
        chip_500.onClick.AddListener(() => chipClicked(chip_500));
        chip_1000.onClick.AddListener(() => chipClicked(chip_1000));
        chip_5000.onClick.AddListener(() => chipClicked(chip_5000));
        spin.onClick.AddListener(() => play());
    }
    public void OnEnable()
    {
        betValue.text = "0";
        chipsValue.text = GameController.Instance.Chips.ToString();
    }

    public void OnDisable()
    {
        GameController.Instance.Chips = int.Parse(chipsValue.text) + int.Parse(betValue.text);
    }

    public void chipClicked(Button button)
    {
        if (button == chip_1)
        {
            if (int.Parse(chipsValue.text) >= 1)
            {
                chipsValue.text = (int.Parse(chipsValue.text) - 1).ToString();
                betValue.text = (int.Parse(betValue.text) + 1).ToString();
            }

        }
        else if (button == chip_5)
        {
            if (int.Parse(chipsValue.text) >= 5)
            {
                chipsValue.text = (int.Parse(chipsValue.text) - 5).ToString();
                betValue.text = (int.Parse(betValue.text) + 5).ToString();
            }
        }
        else if (button == chip_10)
        {
            if (int.Parse(chipsValue.text) >= 10)
            {
                chipsValue.text = (int.Parse(chipsValue.text) - 10).ToString();
                betValue.text = (int.Parse(betValue.text) + 10).ToString();
            }
        }
        else if (button == chip_20)
        {
            if (int.Parse(chipsValue.text) >= 20)
            {
                chipsValue.text = (int.Parse(chipsValue.text) - 20).ToString();
                betValue.text = (int.Parse(betValue.text) + 20).ToString();
            }
        }
        else if (button == chip_50)
        {
            if (int.Parse(chipsValue.text) >= 50)
            {
                chipsValue.text = (int.Parse(chipsValue.text) - 50).ToString();
                betValue.text = (int.Parse(betValue.text) + 50).ToString();
            }
        }
        else if (button == chip_100)
        {
            if (int.Parse(chipsValue.text) >= 100)
            {
                chipsValue.text = (int.Parse(chipsValue.text) - 100).ToString();
                betValue.text = (int.Parse(betValue.text) + 100).ToString();
            }
        }
        else if (button == chip_500)
        {
            if (int.Parse(chipsValue.text) >= 500)
            {
                chipsValue.text = (int.Parse(chipsValue.text) - 500).ToString();
                betValue.text = (int.Parse(betValue.text) + 500).ToString();
            }
        }
        else if (button == chip_1000)
        {
            if (int.Parse(chipsValue.text) >= 1000)
            {
                chipsValue.text = (int.Parse(chipsValue.text) - 1000).ToString();
                betValue.text = (int.Parse(betValue.text) + 1000).ToString();
            }
        }
        else if (button == chip_5000)
        {
            if (int.Parse(chipsValue.text) >= 5000)
            {
                chipsValue.text = (int.Parse(chipsValue.text) - 5000).ToString();
                betValue.text = (int.Parse(betValue.text) + 5000).ToString();
            }
        }
    }

    //Code for when board buttons clicked, bet value assigned to a position & set to 0 on display

    public void play()
    {
        //Game code goes here

        //A list of positions, positions containing a color(enum red, black, or green) & a number, number can be nullable for color green
        //Randomly select a position
        //If the position intersects with the players selected position(s), multiply money from that position & give to player in form of chips
        //Reset all board values to 0
        //Note: if position is red 13 & player has money on red & 1-12, the player would only win from red & lose from 1-12
    }
}