using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class angryKidScript : MonoBehaviour
{

    public Text _text;
    public Image textbox;
    public SpriteRenderer spriteRenderer;
    public bool rightItem;
    public int a; 
    public bool gotBurger = false;
    public bool gotApple = false;
    public Sprite happyKid;
    public Collider2D angryKidCollider;
    public Collider2D playerCollider;
    // Start is called before the first frame update
    void Start()
    {
        a = Random.Range(0, 2);
        if(a == 0)
        {
            rightItem = false;
        }
        if(a == 1)
        {
            rightItem = true;
        }
        _text.GetComponent<Text>().enabled = false;
        textbox.GetComponent<Image>().enabled = false;
        Debug.Log(rightItem);
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(!gotApple && !gotBurger)
        {
            textbox.GetComponent<Image>().enabled = true;
            _text.GetComponent<Text>().enabled = true;
            _text.text = "I'm so hungry, find me some food and I will give you the key";
        }
        if (rightItem == true)
                if (gotBurger)
                {
                    textbox.GetComponent<Image>().enabled = true;
                    _text.GetComponent<Text>().enabled = true;
                    _text.text = "I hate tomatoes but I guess this will do, here's the key";
                    spriteRenderer.sprite = happyKid;
                }
                else if (gotApple)
                {
                    textbox.GetComponent<Image>().enabled = true;
                    _text.GetComponent<Text>().enabled = true;
                    _text.text = "ew I hate fruit, get me something else or no key for you";
                }

         if (rightItem == false)
            {
                if (gotApple)
                {
                    textbox.GetComponent<Image>().enabled = true;
                    _text.GetComponent<Text>().enabled = true;
                    _text.text = "I love apples, thank you here is your key";
                    spriteRenderer.sprite = happyKid;

                }
                else if (gotBurger)
                {
                    textbox.GetComponent<Image>().enabled = true;
                    _text.GetComponent<Text>().enabled = true;
                    _text.text = "I'm actually vegan so I can't eat this, get me something else";
                }

            }



        



    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        textbox.GetComponent<Image>().enabled = false;
        _text.GetComponent<Text>().enabled = false;
       
    }
    private void Update()
    {
       

        

    }



}

 


