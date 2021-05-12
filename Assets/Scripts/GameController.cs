using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using System;
using System.Linq;
using UnityEngine.SceneManagement;

public enum eState
{
    TITLE,
    GAME,
    PAUSE,
    GAMEOVER,
    INSTRUCTIONS,
    MENU,
    EXITGAME
}

public class GameController : MonoBehaviour
{

    #region Singleton
    private static GameController _instance;

    public static GameController Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {

        }
    }
    #endregion



    [Header("Editable values")]
    public eState state = eState.TITLE;
    public int Chips;
    public int Cash;

    [Header("Systems")]
    public GameObject gameOverPanel;
    public TMP_InputField CashToChipsInput;
    public TMP_InputField ChipsToCashInput;
    public TMP_Text cashText;
    public TMP_Text chipsText;

    //Dont touch these variables:
    bool forceOnce = true;
    //InputSystem input;

    public MainMenuController mainMenuController;

    void Start()
    {
        cashText.text = Cash.ToString();
        chipsText.text = Chips.ToString();
    }

    void Update()
    {
        if (state == eState.MENU)
        {
            //turnDisplay.SetActive(false);

            forceOnce = true;
        }

        //Game is running
        if (state == eState.GAME)
        {
            if (forceOnce == true)
            {
                GameSession();

                forceOnce = false;
            }
        }
    }

    public void GameSession()
    {

    }

    public void ChangePlayer()
    {
        //Change player controlled object in here?
    }



    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void ConvertCurrency()
    {
        if (ChipsToCashInput.text != "" && CashToChipsInput.text != "")
        {
            ChipsToCashInput.text = null;
            CashToChipsInput.text = null;
            Debug.Log("Only One Operation is allowed per convertion");
        }
        else if (ChipsToCashInput.text != "" || CashToChipsInput.text != "")
        {
            if (ChipsToCashInput.text != "")
            {
                ChipsToCash();
            }
            else if (CashToChipsInput.text != "")
            {
                CashToChips();
            }
        }
        
        //Update Text
        cashText.text = Cash.ToString();
        chipsText.text = Chips.ToString();

        ChipsToCashInput.text = null;
        CashToChipsInput.text = null;

    }

    private void CashToChips()
    {
        Chips += int.Parse(CashToChipsInput.text);
        Cash -= int.Parse(CashToChipsInput.text);
    }

    private void ChipsToCash()
    {
        if (Chips >= int.Parse(ChipsToCashInput.text))
        {
            Chips -= int.Parse(ChipsToCashInput.text);
            Cash  += int.Parse(ChipsToCashInput.text);
        }
        else if (Chips > 0)
        {
            int allChips = Chips;
            Chips-= allChips;
            Cash += allChips;
        }    
    }
}


