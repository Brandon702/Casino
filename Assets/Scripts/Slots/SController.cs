using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SController : MonoBehaviour
{
    public Button chip1;
    public Button chip2;
    public Button chip3;
    public Button chip4;
    public Button chip5;
    public Button chip6;
    public Button chip7;
    public Button chip8;
    public Button chip9;

    public Button spin;
    public Button stop;

    public TMP_Text betsText;
    public TMP_Text cashText;
    public TMP_Text mainText;

    public ImageRandom imageRandom1;
    public ImageRandom imageRandom2;
    public ImageRandom imageRandom3;
    private bool roundOver = true;
    void Start()
    {
        chip1.onClick.AddListener(() => ChipClicked(chip1));
        chip2.onClick.AddListener(() => ChipClicked(chip2));
        chip3.onClick.AddListener(() => ChipClicked(chip3));
        chip4.onClick.AddListener(() => ChipClicked(chip4));
        chip5.onClick.AddListener(() => ChipClicked(chip5));
        chip6.onClick.AddListener(() => ChipClicked(chip6));
        chip7.onClick.AddListener(() => ChipClicked(chip7));
        chip8.onClick.AddListener(() => ChipClicked(chip8));
        chip9.onClick.AddListener(() => ChipClicked(chip9));
    }

    public void RoundOver()
    {
        int totalVal = 0;

        if (imageRandom1.compareSprites == imageRandom2.compareSprites && imageRandom2.compareSprites == imageRandom3.compareSprites && imageRandom3.compareSprites == imageRandom1.compareSprites)
        {
            if (imageRandom1.sprites[0])
            {
                totalVal = int.Parse(betsText.text);

                totalVal = totalVal * 500000;
                cashText.text = (int.Parse(cashText.text) + totalVal).ToString();
            }
            else if (imageRandom1.sprites[1])
            {
                totalVal = int.Parse(betsText.text);

                totalVal = totalVal * 100000;
                cashText.text = (int.Parse(cashText.text) + totalVal).ToString();
            }
            else if (imageRandom1.sprites[2])
            {
                totalVal = int.Parse(betsText.text);

                totalVal = totalVal * 50000;
                cashText.text = (int.Parse(cashText.text) + totalVal).ToString();
            }
            else if (imageRandom1.sprites[3])
            {
                totalVal = int.Parse(betsText.text);

                totalVal = totalVal * 20000;
                cashText.text = (int.Parse(cashText.text) + totalVal).ToString();
            }
            else if (imageRandom1.sprites[4])
            {
                totalVal = int.Parse(betsText.text);

                totalVal = totalVal * 10000;
                cashText.text = (int.Parse(cashText.text) + totalVal).ToString();
            }
            else if (imageRandom1.sprites[5])
            {
                totalVal = int.Parse(betsText.text);

                totalVal = totalVal * 5000;
                cashText.text = (int.Parse(cashText.text) + totalVal).ToString();
            }
            else if (imageRandom1.sprites[6])
            {
                totalVal = int.Parse(betsText.text);

                totalVal = totalVal * 3000;
                cashText.text = (int.Parse(cashText.text) + totalVal).ToString();
            }
            else if (imageRandom1.sprites[7])
            {
                totalVal = int.Parse(betsText.text);

                totalVal = totalVal * 2000;
                cashText.text = (int.Parse(cashText.text) + totalVal).ToString();
            }
            else if (imageRandom1.sprites[9])
            {
                totalVal = int.Parse(betsText.text);

                totalVal = totalVal * 1000;
                cashText.text = (int.Parse(cashText.text) + totalVal).ToString();
            }
            else
            {
                roundOver = false;
            }
        }  

        if (roundOver)
        {
            spin.gameObject.SetActive(true);
            stop.gameObject.SetActive(false);
            mainText.gameObject.SetActive(true);
            betsText.text = "0";
        }
    }

    public void OnEnable()
    {
        betsText.text = "0";
        cashText.text = GameController.Instance.Chips.ToString();
    }

    public void OnDisable()
    {
        GameController.Instance.Chips = int.Parse(cashText.text) + int.Parse(betsText.text);
    }

    public void ChipClicked(Button button)
    {
        Debug.Log("Chip Clicked");
        if (button == chip1)
        {
            if (int.Parse(cashText.text) >= 1)
            {
                Debug.Log("Convert 1");
                cashText.text = (int.Parse(cashText.text) - 1).ToString();
                betsText.text = (int.Parse(betsText.text) + 1).ToString();
                GameController.Instance.Chips = GameController.Instance.Chips - 1;
            }

        }
        else if (button == chip2)
        {
            if (int.Parse(cashText.text) >= 5)
            {
                cashText.text = (int.Parse(cashText.text) - 5).ToString();
                betsText.text = (int.Parse(betsText.text) + 5).ToString();
                GameController.Instance.Chips = GameController.Instance.Chips - 5;
            }
        }
        else if (button == chip3)
        {
            if (int.Parse(cashText.text) >= 10)
            {
                cashText.text = (int.Parse(cashText.text) - 10).ToString();
                betsText.text = (int.Parse(betsText.text) + 10).ToString();
                GameController.Instance.Chips = GameController.Instance.Chips - 10;
            }
        }
        else if (button == chip4)
        {
            if (int.Parse(cashText.text) >= 20)
            {
                cashText.text = (int.Parse(cashText.text) - 20).ToString();
                betsText.text = (int.Parse(betsText.text) + 20).ToString();
                GameController.Instance.Chips = GameController.Instance.Chips - 20;
            }
        }
        else if (button == chip5)
        {
            if (int.Parse(cashText.text) >= 50)
            {
                cashText.text = (int.Parse(cashText.text) - 50).ToString();
                betsText.text = (int.Parse(betsText.text) + 50).ToString();
                GameController.Instance.Chips = GameController.Instance.Chips - 50;
            }
        }
        else if (button == chip6)
        {
            if (int.Parse(cashText.text) >= 100)
            {
                cashText.text = (int.Parse(cashText.text) - 100).ToString();
                betsText.text = (int.Parse(betsText.text) + 100).ToString();
                GameController.Instance.Chips = GameController.Instance.Chips - 100;
            }
        }
        else if (button == chip7)
        {
            if (int.Parse(cashText.text) >= 500)
            {
                cashText.text = (int.Parse(cashText.text) - 500).ToString();
                betsText.text = (int.Parse(betsText.text) + 500).ToString();
                GameController.Instance.Chips = GameController.Instance.Chips - 500;
            }
        }
        else if (button == chip8)
        {
            if (int.Parse(cashText.text) >= 1000)
            {
                cashText.text = (int.Parse(cashText.text) - 1000).ToString();
                betsText.text = (int.Parse(betsText.text) + 1000).ToString();
                GameController.Instance.Chips = GameController.Instance.Chips - 1000;
            }
        }
        else if (button == chip9)
        {
            if (int.Parse(cashText.text) >= 5000)
            {
                cashText.text = (int.Parse(cashText.text) - 5000).ToString();
                betsText.text = (int.Parse(betsText.text) + 5000).ToString();
                GameController.Instance.Chips = GameController.Instance.Chips - 5000;
            }
        }
    }
}
