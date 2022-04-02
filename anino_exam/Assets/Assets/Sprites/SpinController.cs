using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SpinController : MonoBehaviour
{
    public Sprite[] sprites;
    public float stopTime;
    public Button buttonSpin, btnPlus, btnMinus, btnStop;
    public Text textbtnSpin, txtBetAmount;
    int amount;
    public static int betAmt;
    public int payoutValue;

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

    

    public void endRand()
    {
        enabled = false;

        
        buttonSpin.gameObject.GetComponent<Button>().interactable = true;
        btnPlus.gameObject.GetComponent<Button>().interactable = true;
        btnMinus.gameObject.GetComponent<Button>().interactable = true;
        textbtnSpin.gameObject.GetComponent<Text>().color = Color.yellow;
       

        btnStop.gameObject.SetActive(false);
    }


        public void StartRand()
    {
        int coinsV;
        GameObject betObj = GameObject.Find("SpinScripts");
        BetValue betScript = betObj.GetComponent<BetValue>();
        betAmt = betScript.betAmount;
        GameObject coinsObj = GameObject.Find("CoinsText");
        coinsV = Convert.ToInt32(coinsObj.gameObject.GetComponent<Text>().text);

        if (coinsV < betAmt*20 || betAmt == 0)
        {
            endRand();
            
        }
        else
        {

            enabled = true;

            GameObject winObj = GameObject.Find("WinsValue");
            winObj.gameObject.GetComponent<Text>().text = Convert.ToString(0);
            buttonSpin.gameObject.GetComponent<Button>().interactable = false;
            btnMinus.gameObject.GetComponent<Button>().interactable = false;
            btnPlus.gameObject.GetComponent<Button>().interactable = false;
            textbtnSpin.gameObject.GetComponent<Text>().color = Color.gray;

            btnStop.gameObject.SetActive(true);
            //Invoke("endRand", stopTime);
        }
    }
    public void updateCoins(GameObject coverObj)
    {
        int coinsV;
        GameObject betObj = GameObject.Find("SpinScripts");
        BetValue betScript = betObj.GetComponent<BetValue>();
        betAmt = betScript.betAmount;
        GameObject coinsObj = GameObject.Find("CoinsText");
        coinsV = Convert.ToInt32(coinsObj.gameObject.GetComponent<Text>().text);
        GameObject spinSoundObj = GameObject.Find("AudioSpin");
        AudioSource spinSound = spinSoundObj.GetComponent<AudioSource>();

        if (coinsV < betAmt * 20 || betAmt == 0)
        {
            //set this panel to active true
            coverObj.gameObject.SetActive(true);
            spinSound.Stop();
        }
        else
        {
            //update coins
            spinSound.Play();
            coinsV = coinsV - (betAmt * 20);
            coinsObj.gameObject.GetComponent<Text>().text = Convert.ToString(coinsV);

        }
    }

    IEnumerator StartWait()
    {

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
    }

        public void CalculateWinsValue()
    {
        StartCoroutine(StartWait());

        int totalWins = 0, coinsV, payoutValue = 0;
        GameObject betObj = GameObject.Find("SpinScripts");
        BetValue betScript = betObj.GetComponent<BetValue>();
        amount = betScript.betAmount;
        
        GameObject image1 = GameObject.Find("image1");
        GameObject image2 = GameObject.Find("image2");
        GameObject image3 = GameObject.Find("image3");
        GameObject image4 = GameObject.Find("image4");
        GameObject image5 = GameObject.Find("image5");
        GameObject image6 = GameObject.Find("image6");
        GameObject image7 = GameObject.Find("image7");
        GameObject image8 = GameObject.Find("image8");
        GameObject image9 = GameObject.Find("image9");
        GameObject image10 = GameObject.Find("image10");
        GameObject image11 = GameObject.Find("image11");
        GameObject image12 = GameObject.Find("image12");
        GameObject image13 = GameObject.Find("image13");
        GameObject image14 = GameObject.Find("image14");
        GameObject image15 = GameObject.Find("image15");
        string spriteImg1 = image1.GetComponent<UnityEngine.UI.Image>().sprite.name;
        string spriteImg2 = image2.GetComponent<UnityEngine.UI.Image>().sprite.name;
        string spriteImg3 = image3.GetComponent<UnityEngine.UI.Image>().sprite.name;
        string spriteImg4 = image4.GetComponent<UnityEngine.UI.Image>().sprite.name;
        string spriteImg5 = image5.GetComponent<UnityEngine.UI.Image>().sprite.name;
        string spriteImg6 = image6.GetComponent<UnityEngine.UI.Image>().sprite.name;
        string spriteImg7 = image7.GetComponent<UnityEngine.UI.Image>().sprite.name;
        string spriteImg8 = image8.GetComponent<UnityEngine.UI.Image>().sprite.name;
        string spriteImg9 = image9.GetComponent<UnityEngine.UI.Image>().sprite.name;
        string spriteImg10 = image10.GetComponent<UnityEngine.UI.Image>().sprite.name;
        string spriteImg11 = image11.GetComponent<UnityEngine.UI.Image>().sprite.name;
        string spriteImg12 = image12.GetComponent<UnityEngine.UI.Image>().sprite.name;
        string spriteImg13 = image13.GetComponent<UnityEngine.UI.Image>().sprite.name;
        string spriteImg14 = image14.GetComponent<UnityEngine.UI.Image>().sprite.name;
        string spriteImg15 = image15.GetComponent<UnityEngine.UI.Image>().sprite.name;

        //total of 20 payout lines
        checkPayout(spriteImg1, spriteImg2, spriteImg3, spriteImg4, spriteImg5); //2,2,2,2,2
        checkPayout(spriteImg6, spriteImg7, spriteImg8, spriteImg9, spriteImg10); //1,1,1,1,1
        checkPayout(spriteImg11, spriteImg12, spriteImg13, spriteImg14, spriteImg15); //0,0,0,0,0
        checkPayout(spriteImg11, spriteImg7, spriteImg3, spriteImg9, spriteImg15); //0,1,2,1,0
        checkPayout(spriteImg6, spriteImg2, spriteImg3, spriteImg9, spriteImg15); //1,2,2,1,0
        checkPayout(spriteImg1, spriteImg7, spriteImg3, spriteImg14, spriteImg15); //2,1,2,0,0
        checkPayout(spriteImg11, spriteImg12, spriteImg3, spriteImg9, spriteImg10); //0,0,2,1,1
        checkPayout(spriteImg6, spriteImg7, spriteImg13, spriteImg9, spriteImg10); //1,1,0,1,1
        checkPayout(spriteImg1, spriteImg7, spriteImg8, spriteImg9, spriteImg5); //2,1,1,1,2
        checkPayout(spriteImg1, spriteImg7, spriteImg13, spriteImg9, spriteImg5); //2,1,0,1,2
        checkPayout(spriteImg6, spriteImg7, spriteImg3, spriteImg4, spriteImg5); //1,1,2,2,2
        checkPayout(spriteImg6, spriteImg2, spriteImg13, spriteImg14, spriteImg5); //1,2,0,0,2
        checkPayout(spriteImg1, spriteImg7, spriteImg8, spriteImg9, spriteImg10); //2,1,1,1,1
        checkPayout(spriteImg11, spriteImg7, spriteImg13, spriteImg4, spriteImg10); //0,1,0,2,1
        checkPayout(spriteImg6, spriteImg7, spriteImg13, spriteImg9, spriteImg15); //1,1,0,1,0
        checkPayout(spriteImg11, spriteImg12, spriteImg3, spriteImg14, spriteImg15); //0,0,2,0,0
        checkPayout(spriteImg11, spriteImg12, spriteImg13, spriteImg9, spriteImg15); //0,0,0,1,0
        checkPayout(spriteImg11, spriteImg7, spriteImg3, spriteImg14, spriteImg15); //0,1,2,0,0
        checkPayout(spriteImg11, spriteImg12, spriteImg3, spriteImg14, spriteImg10); //0,0,2,0,1
        checkPayout(spriteImg6, spriteImg12, spriteImg3, spriteImg14, spriteImg15); //1,0,2,0,0

        //betObj.gameObject.GetComponent<SpinController>()
        payoutValue = this.payoutValue;
        
        //calculate total wins
        totalWins = payoutValue * (betAmt * 20);
        Debug.Log(string.Format("payout value: {0}; bet Amt: {1}; total wins: {2}", payoutValue, betAmt, totalWins));
        GameObject winObj = GameObject.Find("WinsValue");
        winObj.gameObject.GetComponent<Text>().text = Convert.ToString(totalWins);
        GameObject coinsObj = GameObject.Find("CoinsText");
        coinsV = Convert.ToInt32(coinsObj.gameObject.GetComponent<Text>().text) + totalWins;
        coinsObj.gameObject.GetComponent<Text>().text = Convert.ToString(coinsV);


        txtBetAmount.gameObject.GetComponent<Text>().text = Convert.ToString(0);
        
        betScript.betAmount = 0;
        this.payoutValue = 0;
        payoutValue = 0;
    }

    public void checkPayout(string elem1, string elem2, string elem3, string elem4, string elem5)
    {
        List<string> elems = new List<string> { elem1, elem2, elem3, elem4, elem5};
        int streakCount = 0;
        string checkElem = "";
        Debug.Log(string.Format("ALL elements: {0} {1} {2} {3} {4}", elem1, elem2, elem3, elem4, elem5));

        //3 same symbols
        var dictionary = new Dictionary<string, int>();

        foreach (string n in elems)
        {
            if (!dictionary.ContainsKey(n))
                dictionary[n] = 0;
            dictionary[n]++;
        }

        foreach (var pair in dictionary) {


            if (pair.Value == 5 )
            {
                checkElem = pair.Key;
                Debug.Log("Pairs: " + pair.Value + " : " + pair.Key);

                streakCount = 5;
            }
            else if(pair.Value == 4)
            {
                checkElem = pair.Key;
                Debug.Log("Pairs: " + pair.Value + " : " + pair.Key);


                streakCount = 4;
            }
            else if(pair.Value == 3)
            {
                checkElem = pair.Key;
                Debug.Log("Pairs: " + pair.Value + " : " + pair.Key);

                streakCount = 3;
            }
        }

        if (streakCount == 5)
        {
            if (checkElem == "symbols_0") { payoutValue = payoutValue + 10; }
            else if (checkElem == "symbols_1") { payoutValue = payoutValue + 25; }
            else if (checkElem == "symbols_2") { payoutValue = payoutValue + 40; }
            else if (checkElem == "symbols_3") { payoutValue = payoutValue + 55; }
            else if (checkElem == "symbols_4") { payoutValue = payoutValue + 70; }
            else if (checkElem == "symbols_5") { payoutValue = payoutValue + 85; }
            else if (checkElem == "symbols_6") { payoutValue = payoutValue + 100; }
            else if (checkElem == "symbols_7") { payoutValue = payoutValue + 115; }
            else if (checkElem == "symbols_8") { payoutValue = payoutValue + 130; }
            else if (checkElem == "symbols_9") { payoutValue = payoutValue + 145; }
            Debug.Log(string.Format("payout value for {1}: {0}", payoutValue, streakCount));
        }
        else if (streakCount == 4)
        {
            if (checkElem == "symbols_0") { payoutValue = payoutValue + 5; }
            else if (checkElem == "symbols_1") { payoutValue = payoutValue + 8; }
            else if (checkElem == "symbols_2") { payoutValue = payoutValue + 11; }
            else if (checkElem == "symbols_3") { payoutValue = payoutValue + 14; }
            else if (checkElem == "symbols_4") { payoutValue = payoutValue + 17; }
            else if (checkElem == "symbols_5") { payoutValue = payoutValue + 20; }
            else if (checkElem == "symbols_6") { payoutValue = payoutValue + 23; }
            else if (checkElem == "symbols_7") { payoutValue = payoutValue + 26; }
            else if (checkElem == "symbols_8") { payoutValue = payoutValue + 29; }
            else if (checkElem == "symbols_9") { payoutValue = payoutValue + 32; }
            Debug.Log(string.Format("payout value for {1}: {0}", payoutValue, streakCount));
        }
        else if (streakCount == 3)
        {
            if (checkElem == "symbols_0") { payoutValue = payoutValue + 1; }
            else if (checkElem == "symbols_1") { payoutValue = payoutValue + 2; }
            else if (checkElem == "symbols_2") { payoutValue = payoutValue + 3; }
            else if (checkElem == "symbols_3") { payoutValue = payoutValue + 4; }
            else if (checkElem == "symbols_4") { payoutValue = payoutValue + 5; }
            else if (checkElem == "symbols_5") { payoutValue = payoutValue + 6; }
            else if (checkElem == "symbols_6") { payoutValue = payoutValue + 7; }
            else if (checkElem == "symbols_7") { payoutValue = payoutValue + 8; }
            else if (checkElem == "symbols_8") { payoutValue = payoutValue + 9; }
            else if (checkElem == "symbols_9") { payoutValue = payoutValue + 10; }
            Debug.Log(string.Format("payout value for {1}: {0}", payoutValue, streakCount));
        }

        
    }
}
