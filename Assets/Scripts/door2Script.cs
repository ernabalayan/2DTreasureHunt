using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class door2Script : MonoBehaviour
{
    public GameObject key2;
    public SpriteRenderer spriteRenderer;
    public BoxCollider2D boxCollider;
    public SpriteRenderer keySpriteRenderer;
    public bool doorOpen;
    public Text _text;
    public Image textbox;



    // Start is called before the first frame update
    void Start()
    {
        _text.GetComponent<Text>().enabled = false;
        textbox.GetComponent<Image>().enabled = false;
        doorOpen = false;
        boxCollider.enabled = true;
        spriteRenderer.enabled = true;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (key2.GetComponent<key2Script>().hasKey == false)
        {
            _text.GetComponent<Text>().enabled = true;
            _text.text = "Find gold key to unlock";
            textbox.GetComponent<Image>().enabled = true;
        }
        if (key2.GetComponent<key2Script>().hasKey)
        {
            doorOpen = true;
            boxCollider.enabled = false;
            spriteRenderer.enabled = false;
        }
        if (doorOpen)
        {
            Destroy(key2);

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        _text.GetComponent<Text>().enabled = false;
        textbox.GetComponent<Image>().enabled = false;
    }
}
