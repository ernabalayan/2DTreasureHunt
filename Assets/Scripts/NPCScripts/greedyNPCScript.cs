using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class greedyNPCScript : MonoBehaviour
{
    public Text _text;
    public Image textbox;
    public bool got10dollars;
    public bool hasGivenMoney;
    public static int moneyGiven = 0;
    public bool giveKey;
    public AudioSource textboxSound;
    public AudioSource cashSound;
    // Start is called before the first frame update
    void Start()
    {
        textboxSound.enabled = false;
        cashSound.enabled = false;
        textbox.GetComponent<Image>().enabled = false;
        _text.GetComponent<Text>().enabled = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!got10dollars && !hasGivenMoney)
        {
            if(collision.gameObject.tag == "Player")
            {
                textboxSound.enabled = true;
                textbox.GetComponent<Image>().enabled = true;
                _text.GetComponent<Text>().enabled = true;
                _text.text = "Here's the deal, if you give all of us $10 we'll give you the key to the house";
            }
        }
        if (GameObject.Find("Player").GetComponent<playerscript>().score >= 10 && got10dollars == false)
        {
            textboxSound.enabled = true;
            cashSound.enabled = true;
            GetComponent<AudioSource>().enabled = true;
               textbox.GetComponent<Image>().enabled = true;
               _text.GetComponent<Text>().enabled = true;
               got10dollars = true;
               moneyGiven += 10;
               GameObject.Find("Player").GetComponent<playerscript>().score -= 10;
               _text.text = "Thanks, now give the rest of the players $10";
            
        }

        if (moneyGiven == 30)
        {

            textbox.GetComponent<Image>().enabled = true;
            _text.GetComponent<Text>().enabled = true;
            _text.text = "here is your key";
            giveKey = true;

        }




    }
    void OnCollisionExit2D(Collision2D collision)
    {
        textboxSound.enabled = false;
        textbox.GetComponent<Image>().enabled = false;
        _text.GetComponent<Text>().enabled = false;

    }
    // Update is called once per frame
    void Update()
    {
       



       

    }
    
}
