using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SpinController : MonoBehaviour
{
    public Sprite[] sprites;
    public float stopTime;
    public Button buttonSpin, btnPlus, btnMinus;
    public Text textbtnSpin, txtBetAmount;
    int amount;

    // Start is called before the first frame update
    void Start()
    {
        enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        startSpin();
    }

    public void startSpin()
    {
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = sprites[UnityEngine.Random.Range(0,sprites.Length)];
        
        
    }

    

    void endRand()
    {
        enabled = false;
        buttonSpin.gameObject.GetComponent<Button>().interactable = true;
        btnPlus.gameObject.GetComponent<Button>().interactable = true;
        btnMinus.gameObject.GetComponent<Button>().interactable = true;
        textbtnSpin.gameObject.GetComponent<Text>().color = Color.yellow;
        txtBetAmount.gameObject.GetComponent<Text>().text = Convert.ToString(0);
        GameObject betObj = GameObject.Find("SpinScripts");
        BetValue betScript = betObj.GetComponent <BetValue>();
        betScript.betAmount = 0;
    }
    
    public void StartRand()
    {
        enabled = true;
        buttonSpin.gameObject.GetComponent<Button>().interactable = false;
        btnMinus.gameObject.GetComponent<Button>().interactable = false;
        btnPlus.gameObject.GetComponent<Button>().interactable = false;
        textbtnSpin.gameObject.GetComponent<Text>().color = Color.gray;
        Invoke("endRand", stopTime);
    }
}
