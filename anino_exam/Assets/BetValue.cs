using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BetValue : MonoBehaviour
{

    public Text textBetAmount;
    public int betAmount;
    // Start is called before the first frame update
    void Start()
    {
        betAmount = Convert.ToInt32(textBetAmount.gameObject.GetComponent<Text>().text);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addBet()
    {
        betAmount++;
        textBetAmount.gameObject.GetComponent<Text>().text = Convert.ToString(betAmount);
    }

    public void minusBet()
    {
        betAmount = betAmount - 1;
        textBetAmount.gameObject.GetComponent<Text>().text = Convert.ToString(betAmount);
    }
}
