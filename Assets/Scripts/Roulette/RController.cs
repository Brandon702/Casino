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
    public TMP_Text resultText;
    public Button spin;
    public List<Button> betPositions = new List<Button>();
    public List<Sprite> chipImages = new List<Sprite>();
    public Sprite blank;
    public List<Location> locations = new List<Location>();


    private List<int> betPositionValues = new List<int>();

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
        spin.onClick.AddListener(() => Play());

        for (int i = 0; i < betPositions.Count; i++)
        {
            betPositionValues.Add(0);
            Button button = betPositions[i];

        }

        for(int i = 0; i <= 36; i++)
        {
            bool setEven;
            eColors color = eColors.Green;

            if (i % 2 == 0)
            {
                setEven = true;
            }
            else
            {
                setEven = false;
            }

            if (i == 0)
            {
                color = eColors.Green;
            }
            else if (i == 1 || i == 3 || i == 5 || i == 7 || i == 9 || i == 12 || i == 14 || i == 16 || i == 18 || i == 19 || i == 21 || i == 23 || i == 25 || i == 27 || i == 30 || i == 32 || i == 34 || i == 36)
            {
                color = eColors.Red;
            }
            else
            {
                color = eColors.Black;
            }
            locations.Add(new Location(i, color, setEven));
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

    //It takes in a default of button at index 0

    public void betSet(Button button)
    {
        int location = -1;
        if (button == betPositions[0])
        {
            location = 0;
        }
        else if (button == betPositions[1])
        {
            location = 1;
        }
        else if (button == betPositions[2])
        {
            location = 2;
        }
        else if (button == betPositions[3])
        {
            location = 3;
        }
        else if (button == betPositions[4])
        {
            location = 4;
        }
        else if (button == betPositions[5])
        {
            location = 5;
        }
        else if (button == betPositions[6])
        {
            location = 6;
        }
        else if (button == betPositions[7])
        {
            location = 7;
        }
        else if (button == betPositions[8])
        {
            location = 8;
        }
        else if (button == betPositions[9])
        {
            location = 9;
        }
        else if (button == betPositions[10])
        {
            location = 10;
        }
        else if (button == betPositions[11])
        {
            location = 11;
        }
        else if (button == betPositions[12])
        {
            location = 12;
        }
        else if (button == betPositions[13])
        {
            location = 13;
        }
        else if (button == betPositions[14])
        {
            location = 14;
        }
        else if (button == betPositions[15])
        {
            location = 15;
        }
        else if (button == betPositions[16])
        {
            location = 16;
        }
        else if (button == betPositions[17])
        {
            location = 17;
        }
        else if (button == betPositions[18])
        {
            location = 18;
        }
        else if (button == betPositions[19])
        {
            location = 19;
        }
        else if (button == betPositions[20])
        {
            location = 20;
        }
        else if (button == betPositions[21])
        {
            location = 21;
        }
        else if (button == betPositions[22])
        {
            location = 22;
        }
        else if (button == betPositions[23])
        {
            location = 23;
        }
        else if (button == betPositions[24])
        {
            location = 24;
        }
        else if (button == betPositions[25])
        {
            location = 25;
        }
        else if (button == betPositions[26])
        {
            location = 26;
        }
        else if (button == betPositions[27])
        {
            location = 27;
        }
        else if (button == betPositions[28])
        {
            location = 28;
        }
        else if (button == betPositions[29])
        {
            location = 29;
        }
        else if (button == betPositions[30])
        {
            location = 30;
        }
        else if (button == betPositions[31])
        {
            location = 31;
        }
        else if (button == betPositions[32])
        {
            location = 32;
        }
        else if (button == betPositions[33])
        {
            location = 33;
        }
        else if (button == betPositions[34])
        {
            location = 34;
        }
        else if (button == betPositions[35])
        {
            location = 35;
        }
        else if (button == betPositions[36])
        {
            location = 36;
        }
        else if (button == betPositions[37])
        {
            location = 37;
        }
        else if (button == betPositions[38])
        {
            location = 38;
        }
        else if (button == betPositions[39])
        {
            location = 39;
        }
        else if (button == betPositions[40])
        {
            location = 40;
        }
        else if (button == betPositions[41])
        {
            location = 41;
        }
        else if (button == betPositions[42])
        {
            location = 42;
        }
        else if (button == betPositions[43])
        {
            location = 43;
        }
        else if (button == betPositions[44])
        {
            location = 44;
        }
        else if (button == betPositions[45])
        {
            location = 45;
        }
        else if (button == betPositions[46])
        {
            location = 46;
        }
        else if (button == betPositions[47])
        {
            location = 47;
        }
        else if (button == betPositions[48])
        {
            location = 48;
        }
        betPositionValues[location] += int.Parse(betValue.text);
        betPositions[location].image.sprite = setChip();
        betValue.text = 0 + "";
    }

    public Sprite setChip()
    {
        Sprite chipImage = blank;
        //For placing chip textures over the button area
        if (int.Parse(betValue.text) < 5 && int.Parse(betValue.text) != 0)
        {
            //Place chip 1
            chipImage = chipImages[0];
        }
        else if (int.Parse(betValue.text) < 10 && int.Parse(betValue.text) != 0)
        {
            //Place chip 5
            chipImage = chipImages[1];
        }
        else if (int.Parse(betValue.text) < 20 && int.Parse(betValue.text) != 0)
        {
            //Place chip 10
            chipImage = chipImages[2];
        }
        else if (int.Parse(betValue.text) < 50 && int.Parse(betValue.text) != 0)
        {
            //Place chip 20
            chipImage = chipImages[3];
        }
        else if (int.Parse(betValue.text) < 100 && int.Parse(betValue.text) != 0)
        {
            //Place chip 50
            chipImage = chipImages[4];
        }
        else if (int.Parse(betValue.text) < 500 && int.Parse(betValue.text) != 0)
        {
            //Place chip 100
            chipImage = chipImages[5];
        }
        else if (int.Parse(betValue.text) < 1000 && int.Parse(betValue.text) != 0)
        {
            //Place chip 500
            chipImage = chipImages[6];
        }
        else if (int.Parse(betValue.text) < 5000 && int.Parse(betValue.text) != 0)
        {
            //Place chip 1000
            chipImage = chipImages[7];
        }
        else if (int.Parse(betValue.text) >= 5000 && int.Parse(betValue.text) != 0)
        {
            //Place chip 5000
            chipImage = chipImages[8];
        }
        else if (int.Parse(betValue.text) ==0)
        {
            //Dont change the image
            //Low priority
        }
        return chipImage;
    }    

    public void Play()
    {
        int totalBetVal = 0;

        for(int i=0; i < betPositionValues.Count; i++)
        {
            totalBetVal += betPositionValues[i];
        }

        if(totalBetVal != 0)
        {
            //Select a random position
            int selectedVal = Random.Range(0, 36);
            int totalVal = 0;
            Location selectedSpot = locations[selectedVal];
            resultText.text = "Position: " + (selectedSpot.val);
            if (selectedSpot.even) resultText.text += " | Even/Odd: Even";
            else resultText.text += " | Even/Odd: Odd";
            resultText.text += " | Color: " + selectedSpot._color;
            if (selectedSpot.val == 0)
            {
                totalVal = betPositionValues[48];
                totalVal = totalVal * 10;
                chipsValue.text = (int.Parse(chipsValue.text) + totalVal).ToString();
            }
            else
            {
                if (selectedSpot.val <= 18)
                {
                    totalVal = betPositionValues[42];
                    totalVal = totalVal * 2;
                    chipsValue.text = (int.Parse(chipsValue.text) + totalVal).ToString();
                }
                if (selectedSpot.val >= 19)
                {
                    totalVal = betPositionValues[47];
                    totalVal = totalVal * 2;
                    chipsValue.text = (int.Parse(chipsValue.text) + totalVal).ToString();
                }
                if (selectedSpot._color == eColors.Red)
                {
                    totalVal = betPositionValues[45];
                    totalVal = totalVal * 2;
                    chipsValue.text = (int.Parse(chipsValue.text) + totalVal).ToString();
                }
                if (selectedSpot._color == eColors.Black)
                {
                    totalVal = betPositionValues[46];
                    totalVal = totalVal * 2;
                    chipsValue.text = (int.Parse(chipsValue.text) + totalVal).ToString();
                }
                if (selectedSpot.even == true)
                {
                    totalVal = betPositionValues[43];
                    totalVal = totalVal * 2;
                    chipsValue.text = (int.Parse(chipsValue.text) + totalVal).ToString();
                }
                if (selectedSpot.even == false)
                {
                    totalVal = betPositionValues[44];
                    totalVal = totalVal * 2;
                    chipsValue.text = (int.Parse(chipsValue.text) + totalVal).ToString();
                }
                if (selectedSpot.val <= 12)
                {
                    totalVal = betPositionValues[39];
                    totalVal = totalVal * 3;
                    chipsValue.text = (int.Parse(chipsValue.text) + totalVal).ToString();
                }
                if (selectedSpot.val > 12 && selectedSpot.val < 25)
                {
                    totalVal = betPositionValues[40];
                    totalVal = totalVal * 3;
                    chipsValue.text = (int.Parse(chipsValue.text) + totalVal).ToString();
                }
                if (selectedSpot.val >= 25)
                {
                    totalVal = betPositionValues[41];
                    totalVal = totalVal * 3;
                    chipsValue.text = (int.Parse(chipsValue.text) + totalVal).ToString();
                }
                if (selectedSpot.val == 1 || selectedSpot.val == 4 || selectedSpot.val == 7 || selectedSpot.val == 10 || selectedSpot.val == 13 || selectedSpot.val == 16 || selectedSpot.val == 19 || selectedSpot.val == 22 || selectedSpot.val == 25 || selectedSpot.val == 28 || selectedSpot.val == 31 || selectedSpot.val == 34)
                {
                    totalVal = betPositionValues[36];
                    totalVal = totalVal * 3;
                    chipsValue.text = (int.Parse(chipsValue.text) + totalVal).ToString();
                }
                if (selectedSpot.val == 2 || selectedSpot.val == 5 || selectedSpot.val == 8 || selectedSpot.val == 11 || selectedSpot.val == 14 || selectedSpot.val == 17 || selectedSpot.val == 20 || selectedSpot.val == 23 || selectedSpot.val == 26 || selectedSpot.val == 29 || selectedSpot.val == 32 || selectedSpot.val == 35)
                {
                    totalVal = betPositionValues[37];
                    totalVal = totalVal * 3;
                    chipsValue.text = (int.Parse(chipsValue.text) + totalVal).ToString();
                }
                if (selectedSpot.val == 3 || selectedSpot.val == 6 || selectedSpot.val == 9 || selectedSpot.val == 12 || selectedSpot.val == 15 || selectedSpot.val == 18 || selectedSpot.val == 21 || selectedSpot.val == 24 || selectedSpot.val == 27 || selectedSpot.val == 30 || selectedSpot.val == 33 || selectedSpot.val == 36)
                {
                    totalVal = betPositionValues[38];
                    totalVal = totalVal * 3;
                    chipsValue.text = (int.Parse(chipsValue.text) + totalVal).ToString();
                }
                totalVal = betPositionValues[selectedSpot.val - 1];
                totalVal = totalVal * 5;
                chipsValue.text = (int.Parse(chipsValue.text) + totalVal).ToString();
            }
        }
        else
        {
            resultText.text = "Please enter a bet to spin the wheel";
        }
        //Reset Board
        for (int i = 0; i < betPositions.Count; i++)
        {
            Button betPosition = betPositions[i];
            betPosition.image.sprite = blank;
            betPositionValues[i] = 0;
        }
        totalBetVal = 0;
    }
}