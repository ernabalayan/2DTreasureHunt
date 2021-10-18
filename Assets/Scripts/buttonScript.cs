﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buttonScript : MonoBehaviour
{
    public Sprite buttonPressed;
    public Sprite buttonNotPressed;
    public bool buttonIsPressed;
    public float timer = 30.0f;
    public Text _timer;
    public bool firstTimePressed;
    //
    //Start is called before the first frame update
    void Start()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<playerscript>().score = 0;
            buttonIsPressed = true;
            GetComponent<SpriteRenderer>().sprite = buttonPressed;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (buttonIsPressed)
        {
            
            timer -= Time.deltaTime;
            _timer.text = "Time Left: " + timer.ToString("0");
        }
        if(timer <= 0.0f)
        {
            firstTimePressed = true;
            buttonIsPressed = false;
            timer = 30.0f;
            GetComponent<SpriteRenderer>().sprite = buttonNotPressed; 
        }
       
    }
}