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
    public TMP_Text spinBtnText;

    public ImageRandom imageRandom;

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

    /*private void RoundOver()
    {
        bool threeStack1 = imageRandom.;
        bool threeStack2 = ;
        bool threeStack3 = ;
        bool threeStack4 = ;
        bool threeStack5 = ;
        bool threeStack6 = ;
        bool threeStack7 = ;
        bool threeStack8 = ;
        bool threeStack9 = ;

        if (*//*make sure the game is not won*//*) return;
        bool roundOver = true;

        if (*//*the images are matched*//*)
        {
            if(*//*threestack1 is matched completely*//*)
            {
                mainText.text = "You Win!";
            }
            else if(*//*threestack2 is matched completely*//*)
            {
                mainText.text = "You Win!";
            }
            else if(*//*threestack3 is matched completely*//*)
            {
                mainText.text = "You Win!";
            }
            else if(*//*threestack4 is matched completely*//*)
            {
                mainText.text = "You Win!";
            }
            else if(*//*threestack5 is matched completely*//*)
            {
                mainText.text = "You Win!";
            }
            else if(*//*threestack7 is matched completely*//*)
            {
                mainText.text = "You Win!";
            }
            else if(*//*threestack8 is matched completely*//*)
            {
                mainText.text = "You Win!";
            }
            else if(*//*threestack9 is matched completely*//*)
            {
                mainText.text = "You Win!";
            }
        }
        else
        {
            roundOver = false;
        }

        if (roundOver)
        {
            spin.gameObject.SetActive(true);
            stop.gameObject.SetActive(false);
            mainText.gameObject.SetActive(true);
            betsText.text = "0";
        }
    }*/

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
