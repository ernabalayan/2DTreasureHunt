using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bossScript : MonoBehaviour
{
    public Text _text;
    public Image textbox;
    public bool got50dollars;
    public bool greenKeyActivated;
    public AudioSource textboxSound;
    public AudioSource cashSound;
    // Start is called before the first frame update
    void Start()
    {
        textboxSound.enabled = false;
        cashSound.enabled = false;
        GetComponent<AudioSource>().enabled = false;
        _text.GetComponent<Text>().enabled = false;
        textbox.GetComponent<Image>().enabled = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(GameObject.Find("Player").GetComponent<playerscript>().score < 70)
        {
            textboxSound.enabled = true;
            _text.GetComponent<Text>().enabled = true;
            textbox.GetComponent<Image>().enabled = true;
            _text.text = "I'll tell you what, if you bring me $70 I'll give you the key";
        }
        if (GameObject.Find("Player").GetComponent<playerscript>().score >= 70)
        {
            textboxSound.enabled = true;
            cashSound.enabled = true;
            GetComponent<AudioSource>().enabled = true;
            _text.GetComponent<Text>().enabled = true;
            textbox.GetComponent<Image>().enabled = true;
            GameObject.Find("Player").GetComponent<playerscript>().score -= 70;
            greenKeyActivated = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        textboxSound.enabled = false;
        _text.GetComponent<Text>().enabled = false;
        textbox.GetComponent<Image>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (greenKeyActivated)
        {
            _text.text = "Congratulations, here is the green key!";
        }
    }
}
