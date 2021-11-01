using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sadNPC3Text : MonoBehaviour
{
    public Text _text;
    public Image textbox;
    public SpriteRenderer spriteRenderer;
    public Sprite happyNPC3;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().enabled = false;
        textbox.GetComponent<Image>().enabled = false;
        _text.GetComponent<Text>().enabled = false;

    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GameObject.Find("sadNPC1").GetComponent<sadNPC1Script>().gotDog == false)
        {
            GetComponent<AudioSource>().enabled = true;
            textbox.GetComponent<Image>().enabled = true;
            _text.GetComponent<Text>().enabled = true;
            _text.text = "I think I saw it run to the left";

        }
        if (GameObject.Find("sadNPC1").GetComponent<sadNPC1Script>().gotDog == true)
        {
            GetComponent<AudioSource>().enabled = true;
            _text.GetComponent<Text>().enabled = true;
            textbox.GetComponent<Image>().enabled = true;
            _text.text = "Thank you so much for helping my friend";
            GetComponent<SpriteRenderer>().sprite = happyNPC3;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        GetComponent<AudioSource>().enabled = false;
        textbox.GetComponent<Image>().enabled = false;
        _text.GetComponent<Text>().enabled = false;
    }
    void Update()
    {

    }
}
