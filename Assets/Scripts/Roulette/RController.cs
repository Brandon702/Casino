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

    public void Start()
    {
        betValue.text = "0";
    }
    public void chipClicked(Button button)
    {
        if(button == chip_1)
        {
            betValue.text = (int.Parse(betValue.text) + 1).ToString();
        }
        else if (button == chip_5)
        {
            betValue.text = (int.Parse(betValue.text) + 5).ToString();
        }
        else if (button == chip_10)
        {
            betValue.text = (int.Parse(betValue.text) + 10).ToString();
        }
        else if (button == chip_20)
        {
            betValue.text = (int.Parse(betValue.text) + 20).ToString();
        }
        else if (button == chip_50)
        {
            betValue.text = (int.Parse(betValue.text) + 50).ToString();
        }
        else if (button == chip_100)
        {
            betValue.text = (int.Parse(betValue.text) + 100).ToString();
        }
        else if (button == chip_500)
        {
            betValue.text = (int.Parse(betValue.text) + 500).ToString();
        }
        else if (button == chip_1000)
        {
            betValue.text = (int.Parse(betValue.text) + 1000).ToString();
        }
        else if (button == chip_5000)
        {
            betValue.text = (int.Parse(betValue.text) + 5000).ToString();
        }

         
    }
}
