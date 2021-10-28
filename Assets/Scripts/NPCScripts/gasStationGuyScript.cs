using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gasStationGuyScript : MonoBehaviour
{
    public Text _text;
    public Image textbox;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        textbox.GetComponent<Image>().enabled = false;
        _text = GameObject.Find("Textbox").GetComponent<Text>();
        _text.GetComponent<Text>().enabled = false;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        textbox.GetComponent<Image>().enabled = true;
        _text.enabled = true;
        _text.text = "Use this red key to open the door down the road from here";
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        textbox.GetComponent<Image>().enabled = false;
        _text.enabled = false;
    }
    void Update()
    {

    }
}
