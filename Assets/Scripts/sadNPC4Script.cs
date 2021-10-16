using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sadNPC4Script : MonoBehaviour
{
    public Text _text;
    public Image textbox;
    public SpriteRenderer spriteRenderer;
    public Sprite happyNPC4;
    public bool wrongPackage;
    public bool rightPackage;
    public GameObject box;
    public BoxCollider2D knobCollider;
    public SpriteRenderer knobRenderer;
    // Start is called before the first frame update
    void Start()
    {
        textbox.GetComponent<Image>().enabled = false;
        _text.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
            textbox.GetComponent<Image>().enabled = true;
            _text.GetComponent<Text>().enabled = true;
            _text.text = "I bough my wife a gift for our anniversary but I can't find it, if you find it for me I'll give you the door knob";
        
        if (wrongPackage)
        {
            textbox.GetComponent<Image>().enabled = true;
            _text.GetComponent<Text>().enabled = true;
            _text.text = "This isn't the right box, find my package please";
        }
        if (rightPackage)
        {
            knobCollider.enabled = true;
            knobRenderer.enabled = true;
            box.transform.parent = this.transform;
            box.transform.localPosition = new Vector2(0, 0);
            textbox.GetComponent<Image>().enabled = true;
            _text.GetComponent<Text>().enabled = true;
            _text.text = "This is the one, thank you!";
            spriteRenderer.sprite = happyNPC4;
            
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
