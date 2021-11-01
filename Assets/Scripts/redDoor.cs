using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class redDoor : MonoBehaviour
{
    public Text _text;
    public Image textbox;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().enabled = false;
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        GetComponent<HingeJoint2D>().enabled = false;
        _text.GetComponent<Text>().enabled = false;
        textbox.GetComponent<Image>().enabled = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(GameObject.Find("redKey").GetComponent<redKnob>().hasKnob == false)
        {
            GetComponent<AudioSource>().enabled = true;
            _text.text = "Find red key to enter";
            _text.GetComponent<Text>().enabled = true;
            textbox.GetComponent<Image>().enabled = true;
            
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        GetComponent<AudioSource>().enabled = false;
        _text.GetComponent<Text>().enabled = false;
        textbox.GetComponent<Image>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
