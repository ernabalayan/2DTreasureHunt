using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sadNPC1Script: MonoBehaviour
{
    public Text _text;
    public Image textbox;
    public SpriteRenderer spriteRenderer;
    public Sprite happyNPC1;
    public bool gotDog;
    // Start is called before the first frame update
    void Start()
    {
        textbox.GetComponent<Image>().enabled = false;
        _text.GetComponent<Text>().enabled = false;

    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && GameObject.Find("cat").GetComponent<catScript>().pickedUpCat == false && GameObject.Find("puppy").GetComponent<dogScript>().pickedUpDog == false)
        {
            textbox.GetComponent<Image>().enabled = true;
            _text.GetComponent<Text>().enabled = true;
            _text.text = "My pet Bartholemew Cumberbatch ran away, can you find him for me in exchange for the key?";
        }
        if(GameObject.Find("cat").GetComponent<catScript>().pickedUpCat == true)
        {
            textbox.GetComponent<Image>().enabled = true;
            _text.GetComponent<Text>().enabled = true;
            _text.text = "this isn't my pet, I have a dog, find him please";
        }
        if (GameObject.Find("puppy").GetComponent<dogScript>().pickedUpDog == true)
        {
            gotDog = true;
            textbox.GetComponent<Image>().enabled = true;
            _text.GetComponent<Text>().enabled = true;
            _text.text = "BENEDICT! thank you for your help here is your key";
            GetComponent<SpriteRenderer>().sprite = happyNPC1;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        textbox.GetComponent<Image>().enabled = false;
        _text.GetComponent<Text>().enabled = false;

    }


    void Update()
    {

    }
}
