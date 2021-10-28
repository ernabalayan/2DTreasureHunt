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
    public AudioSource buttonPressedSound;
    public AudioSource timerSound;
    public AudioSource alarmSound;
    //
    //Start is called before the first frame update
    void Start()
    {
        buttonPressedSound.enabled = false;
        timerSound.enabled = false;
        alarmSound.enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            buttonPressedSound.enabled = true;
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
            timerSound.enabled = true;
            print("1");
           // speedScript.instance.sliderParent.gameObject.SetActive(true);
            //speedScript.instance.sliderValue = timer / 30;
            timer -= Time.deltaTime;
            _timer.text = "Time Left: " + timer.ToString("0");
        }
        if(timer <= 0.0f)
        {
            timerSound.enabled = false;
            alarmSound.enabled = true;
            GameObject.Find("Player").GetComponent<playerscript>().moveSpeed = 50f;
            print("2");
            speedScript.instance.sliderParent.gameObject.SetActive(false);
            firstTimePressed = true;
            buttonIsPressed = false;
            timer = 30.0f;
            GetComponent<SpriteRenderer>().sprite = buttonNotPressed;
            GameObject.Find("speed").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("speed").GetComponent<BoxCollider2D>().enabled = true;
        }
       
    }
}
