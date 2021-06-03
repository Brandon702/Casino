using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BJController : MonoBehaviour
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
    public Button deal;
    public Button hit;
    public Button stand;
    private int standClicked = 0;

    public UserInput playerScript;
    public UserInput dealerScript;

    public TMP_Text scoreText;
    public TMP_Text dealerScoreText;
    public TMP_Text betsText;
    public TMP_Text cashText;
    public TMP_Text mainText;
    public TMP_Text standBtnText;

    public GameObject[] playerCards;
    public GameObject[] dealerCards;

    public GameObject hideCard;
    int money = 0;
    int hitCards = 0;
    int dealCards = 0;

    void Start()
    {
        deal.onClick.AddListener(() => DealClicked());
        hit.onClick.AddListener(() => HitClicked());
        stand.onClick.AddListener(() => StandClicked());
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

    private void DealClicked()
    {
        playerScript.ResetHand();
        dealerScript.ResetHand();

        mainText.gameObject.SetActive(false);
        dealerScoreText.gameObject.SetActive(false);
        GameObject.Find("Deck").GetComponent<Deck>().Shuffle();
        playerScript.StartHand();
        dealerScript.StartHand();

        scoreText.text = playerScript.handValue.ToString();
        dealerScoreText.text = "Hand: " + dealerScript.handValue.ToString();

        hideCard.GetComponent<Renderer>().enabled = true;

        deal.gameObject.SetActive(false);
        hit.gameObject.SetActive(true);
        stand.gameObject.SetActive(true);
        standBtnText.text = "Stand";

        /*money = 0;
        betsText.text = "$" + money.ToString();
        playerScript.AdjustMoney(-15);
        cashText.text = "$" + playerScript.GetMoney().ToString();*/
    }

    private void HitClicked()
    {
        if (playerScript.cardIndex <= 10)
        {
            playerScript.GetCard();
            scoreText.text = playerScript.handValue.ToString();
            playerCards[hitCards].GetComponent<Image>().enabled = true;
            hitCards++;
            if (playerScript.handValue > 20) RoundOver();
        }
    }

    private void StandClicked()
    {
        standClicked++;
        if (standClicked > 1) RoundOver();
        HitDealer();
        standBtnText.text = "Call";
    }

    private void HitDealer()
    {
        while (dealerScript.handValue < 16 && dealerScript.cardIndex < 10)
        {
            dealerScript.GetCard();
            dealerScoreText.text = "Hand: " + dealerScript.handValue.ToString();
            dealerCards[dealCards].GetComponent<Image>().enabled = true;
            hitCards++;
        }
    }

    private void RoundOver()
    {
        bool playerBust = playerScript.handValue > 21;
        bool dealerBust = dealerScript.handValue > 21;
        bool player21 = playerScript.handValue == 21;
        bool dealer21 = dealerScript.handValue == 21;

        if (standClicked < 2 && !playerBust && !dealerBust && !player21 && !dealer21) return;
        bool roundOver = true;

        if (playerBust && dealerBust)
        {
            mainText.text = "All bust: Bets returned";
            playerScript.AdjustMoney(money / 2);
        }
        else if (playerBust || (!dealerBust && dealerScript.handValue > playerScript.handValue))
        {
            mainText.text = "Dealer Wins!";
        }
        else if (dealerBust || playerScript.handValue > dealerScript.handValue)
        {
            mainText.text = "You Win!";
            playerScript.AdjustMoney(money);
        }
        else if (playerScript.handValue == dealerScript.handValue)
        {
            mainText.text = "Push: Bets Returned";
            playerScript.AdjustMoney(money / 2);
        }
        else
        {
            roundOver = false;
        }

        if (roundOver)
        {
            hit.gameObject.SetActive(false);
            stand.gameObject.SetActive(false);
            deal.gameObject.SetActive(true);
            mainText.gameObject.SetActive(true);
            dealerScoreText.gameObject.SetActive(true);
            hideCard.GetComponent<Renderer>().enabled = false;
            betsText.text = "0";

            foreach (GameObject go in playerCards)
            {
                go.GetComponent<Image>().enabled = false;
            }
            hitCards = 0;
            
            foreach (GameObject dc in dealerCards)
            {
                dc.GetComponent<Image>().enabled = false;
            }
            dealCards = 0;
            //cashText.text = "$" + playerScript.GetMoney().ToString();
            standClicked = 0;
        }
    }

    /*private void ChipClicked()
    {
        TMP_Text newBet = chip1.GetComponentInChildren(typeof(TMP_Text)) as TMP_Text;
        int intBet = int.Parse(newBet.text.ToString().Remove(0, 1));
        playerScript.AdjustMoney(-intBet);
        cashText.text = "$" + playerScript.GetMoney().ToString();
        money += (intBet * 2);
        betsText.text = "$" + money.ToString();
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