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
    public List<Button> betPositions = new List<Button>();
    public List<int> betPositionValues = new List<int>();

    public void Start()
    {
        chip_1.onClick.AddListener(()    => chipClicked(chip_1));
        chip_5.onClick.AddListener(()    => chipClicked(chip_5));
        chip_10.onClick.AddListener(()   => chipClicked(chip_10));
        chip_20.onClick.AddListener(()   => chipClicked(chip_20));
        chip_50.onClick.AddListener(()   => chipClicked(chip_50));
        chip_100.onClick.AddListener(()  => chipClicked(chip_100));
        chip_500.onClick.AddListener(()  => chipClicked(chip_500));
        chip_1000.onClick.AddListener(() => chipClicked(chip_1000));
        chip_5000.onClick.AddListener(() => chipClicked(chip_5000));
        spin.onClick.AddListener(() => play());

        foreach(Button button in betPositions)
        {
            button.onClick.AddListener(() => betSet(button));
            Debug.Log("Value Set");
            betPositionValues.Add(0);
        }
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

    //Code for when board buttons clicked, bet value assigned to a position & set bet to 0 on display

    public void betSet(Button button)
    {
        if(button = betPositions[0])
        {
            betPositionValues[0] = int.Parse(betValue.text);
        }
        else if (button = betPositions[1])
        {
            betPositionValues[1] = int.Parse(betValue.text);
        }
        else if (button = betPositions[2])
        {
            betPositionValues[2] = int.Parse(betValue.text);
        }
        else if (button = betPositions[3])
        {
            betPositionValues[3] = int.Parse(betValue.text);
        }
        else if (button = betPositions[4])
        {
            betPositionValues[4] = int.Parse(betValue.text);
        }
        else if (button = betPositions[5])
        {
            betPositionValues[5] = int.Parse(betValue.text);
        }
        else if (button = betPositions[6])
        {
            betPositionValues[6] = int.Parse(betValue.text);
        }
        else if (button = betPositions[7])
        {
            betPositionValues[7] = int.Parse(betValue.text);
        }
        else if (button = betPositions[8])
        {
            betPositionValues[8] = int.Parse(betValue.text);
        }
        else if (button = betPositions[9])
        {
            betPositionValues[9] = int.Parse(betValue.text);
        }
        else if (button = betPositions[10])
        {
            betPositionValues[10] = int.Parse(betValue.text);
        }
        else if (button = betPositions[11])
        {
            betPositionValues[11] = int.Parse(betValue.text);
        }
        else if (button = betPositions[12])
        {
            betPositionValues[12] = int.Parse(betValue.text);
        }
        else if (button = betPositions[13])
        {
            betPositionValues[13] = int.Parse(betValue.text);
        }
        else if (button = betPositions[14])
        {
            betPositionValues[14] = int.Parse(betValue.text);
        }
        else if (button = betPositions[15])
        {
            betPositionValues[15] = int.Parse(betValue.text);
        }
        else if (button = betPositions[16])
        {
            betPositionValues[16] = int.Parse(betValue.text);
        }
        else if (button = betPositions[17])
        {
            betPositionValues[17] = int.Parse(betValue.text);
        }
        else if (button = betPositions[18])
        {
            betPositionValues[18] = int.Parse(betValue.text);
        }
        else if (button = betPositions[19])
        {
            betPositionValues[19] = int.Parse(betValue.text);
        }
        else if (button = betPositions[20])
        {
            betPositionValues[20] = int.Parse(betValue.text);
        }
        else if (button = betPositions[21])
        {
            betPositionValues[21] = int.Parse(betValue.text);
        }
        else if (button = betPositions[22])
        {
            betPositionValues[22] = int.Parse(betValue.text);
        }
        else if (button = betPositions[23])
        {
            betPositionValues[23] = int.Parse(betValue.text);
        }
        else if (button = betPositions[24])
        {
            betPositionValues[24] = int.Parse(betValue.text);
        }
        else if (button = betPositions[25])
        {
            betPositionValues[25] = int.Parse(betValue.text);
        }
        else if (button = betPositions[26])
        {
            betPositionValues[26] = int.Parse(betValue.text);
        }
        else if (button = betPositions[27])
        {
            betPositionValues[27] = int.Parse(betValue.text);
        }
        else if (button = betPositions[28])
        {
            betPositionValues[28] = int.Parse(betValue.text);
        }
        else if (button = betPositions[29])
        {
            betPositionValues[29] = int.Parse(betValue.text);
        }
        else if (button = betPositions[30])
        {
            betPositionValues[30] = int.Parse(betValue.text);
        }
        else if (button = betPositions[31])
        {
            betPositionValues[31] = int.Parse(betValue.text);
        }
        else if (button = betPositions[32])
        {
            betPositionValues[32] = int.Parse(betValue.text);
        }
        else if (button = betPositions[33])
        {
            betPositionValues[33] = int.Parse(betValue.text);
        }
        else if (button = betPositions[34])
        {
            betPositionValues[34] = int.Parse(betValue.text);
        }
        else if (button = betPositions[35])
        {
            betPositionValues[35] = int.Parse(betValue.text);
        }
        else if (button = betPositions[36])
        {
            betPositionValues[36] = int.Parse(betValue.text);
        }
        else if (button = betPositions[37])
        {
            betPositionValues[37] = int.Parse(betValue.text);
        }
        else if (button = betPositions[38])
        {
            betPositionValues[38] = int.Parse(betValue.text);
        }
        else if (button = betPositions[39])
        {
            betPositionValues[39] = int.Parse(betValue.text);
        }
        else if (button = betPositions[40])
        {
            betPositionValues[40] = int.Parse(betValue.text);
        }
        else if (button = betPositions[41])
        {
            betPositionValues[41] = int.Parse(betValue.text);
        }
        else if (button = betPositions[42])
        {
            betPositionValues[42] = int.Parse(betValue.text);
        }
        else if (button = betPositions[43])
        {
            betPositionValues[43] = int.Parse(betValue.text);
        }
        else if (button = betPositions[44])
        {
            betPositionValues[44] = int.Parse(betValue.text);
        }
        else if (button = betPositions[45])
        {
            betPositionValues[45] = int.Parse(betValue.text);
        }
        else if (button = betPositions[46])
        {
            betPositionValues[46] = int.Parse(betValue.text);
        }
        else if (button = betPositions[47])
        {
            betPositionValues[47] = int.Parse(betValue.text);
        }
        else if (button = betPositions[48])
        {
            betPositionValues[48] = int.Parse(betValue.text);
        }
        else if (button = betPositions[49])
        {
            betPositionValues[49] = int.Parse(betValue.text);
        }
        placeChip();
        betValue.text = 0 + "";
    }

    public void placeChip()
    {
        //For placing chip textures over the button area
        if (int.Parse(betValue.text) < 5)
        {
            //Place chip 1
        }
        else if (int.Parse(betValue.text) < 10)
        {
            //Place chip 5
        }
        else if (int.Parse(betValue.text) < 20)
        {
            //Place chip 10
        }
        else if (int.Parse(betValue.text) < 50)
        {
            //Place chip 20
        }
        else if (int.Parse(betValue.text) < 100)
        {
            //Place chip 50
        }
        else if (int.Parse(betValue.text) < 500)
        {
            //Place chip 100
        }
        else if (int.Parse(betValue.text) < 1000)
        {
            //Place chip 500
        }
        else if (int.Parse(betValue.text) < 5000)
        {
            //Place chip 1000
        }
        else if (int.Parse(betValue.text) >= 5000)
        {
            //Place chip 5000
        }
    }    

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