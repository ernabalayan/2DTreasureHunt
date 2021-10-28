using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doorScript : MonoBehaviour
{
    public GameObject key;
    public Collider2D keyCollider;
    public SpriteRenderer spriteRenderer;
    public BoxCollider2D boxCollider;
    public SpriteRenderer keySpriteRenderer;
    public PolygonCollider2D keySpriteCollider;
    public bool doorOpen;
    public Text _text;
    public Image textbox;
  

  
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().enabled = false;
        _text.GetComponent<Text>().enabled = false;
        textbox.GetComponent<Image>().enabled = false;
        doorOpen = false;
        boxCollider.enabled = true;
        spriteRenderer.enabled = true;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (key.GetComponent<keyScript>().hasKey == false)
        {
            GetComponent<AudioSource>().enabled = true;
            _text.GetComponent<Text>().enabled = true;
            _text.text = "Find gold key to unlock";
            textbox.GetComponent<Image>().enabled = true;
        }

            if (key.GetComponent<keyScript>().hasKey)
        {
            doorOpen = true;
            boxCollider.enabled = false;
            spriteRenderer.enabled = false;
        }
        if (doorOpen)
        {
            Destroy(key);

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        GetComponent<AudioSource>().enabled = false;
        _text.GetComponent<Text>().enabled = false;
        textbox.GetComponent<Image>().enabled = false;
    }
    // Update is called once per frame

}
