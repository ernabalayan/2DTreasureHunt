using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sadNPC2Script: MonoBehaviour
{
    public Text _text;
    public Image textbox;
    public SpriteRenderer spriteRenderer;
    public Sprite happyNPC2;
    // Start is called before the first frame update
    void Start()
    {
        textbox.GetComponent<Image>().enabled = false;
        _text.GetComponent<Text>().enabled = false;
        
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(GameObject.Find("sadNPC1").GetComponent<sadNPC1Script>().gotDog == false)
        {
            textbox.GetComponent<Image>().enabled = true;
            _text.GetComponent<Text>().enabled = true;
            _text.text = "Can you help her find her pet please?";
            
        }
        if (GameObject.Find("sadNPC1").GetComponent<sadNPC1Script>().gotDog == true)
        {

            _text.GetComponent<Text>().enabled = true;
            textbox.GetComponent<Image>().enabled = true;
            _text.text = "Thank you so much for helping my friend";
            GetComponent<SpriteRenderer>().sprite = happyNPC2;
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
