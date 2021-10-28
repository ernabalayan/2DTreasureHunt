using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class greenDoor : MonoBehaviour
{
    public Text _text;
    public Image textbox;

    // Start is called before the first frame update
    void Start()
    {
        _text.GetComponent<Text>().enabled = false;
        textbox.GetComponent<Image>().enabled = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (GameObject.Find("greenKey").GetComponent<greenKey>().hasKey == false)
            {
                _text.text = "Find green key to enter";
                _text.GetComponent<Text>().enabled = true;
                textbox.GetComponent<Image>().enabled = true;

            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        _text.GetComponent<Text>().enabled = false;
        textbox.GetComponent<Image>().enabled = false;
    }
    // Update is called once per frame
}
