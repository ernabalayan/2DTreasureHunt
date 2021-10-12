using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class storeClerkScript : MonoBehaviour
{

    public Text _text;
    public GameObject blueKnobIcon;
    public GameObject greenKnobIcon;
    public GameObject redKnobIcon;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        _text = GameObject.Find("Textbox").GetComponent<Text>();
        _text.GetComponent<Text>().enabled = false;
        GameObject.Find("blueKnobIcon");
        GameObject.Find("greenKnobIcon");
        GameObject.Find("redKnobIcon");

    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            _text.GetComponent<Text>().enabled = true;

            if (redKnobIcon.GetComponent<SpriteRenderer>().enabled == false && blueKnobIcon.GetComponent<SpriteRenderer>().enabled == false && greenKnobIcon.GetComponent<SpriteRenderer>().enabled == false)
            {
                Debug.Log("store clerk speaking");
                _text.text = "The teacher has all the answers go talk to her";
            }
            if (redKnobIcon.GetComponent<SpriteRenderer>().enabled == true && blueKnobIcon.GetComponent<SpriteRenderer>().enabled == false && greenKnobIcon.GetComponent<SpriteRenderer>().enabled == false)
            {
                Debug.Log("store clerk speaking");
                _text.text = "I think the chef knows something ";

            }
            if (redKnobIcon.GetComponent<SpriteRenderer>().enabled == true && blueKnobIcon.GetComponent<SpriteRenderer>().enabled == true && greenKnobIcon.GetComponent<SpriteRenderer>().enabled == false)
            {
                Debug.Log("store clerk speaking");
                _text.text = "the pharmacy girl saw something i bet";
            }
            //if (redKnobIcon.GetComponent<SpriteRenderer>().enabled == true && blueKnobIcon.GetComponent<SpriteRenderer>().enabled == true && greenKnobIcon.GetComponent<SpriteRenderer>().enabled == true)
            //{
            // _text.text = " you did it! ";
            // animator.enabled 
            // }
            //_text.text = " find red knob ";

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _text.GetComponent<Text>().enabled = false;
        Debug.Log("not colliding");
    }

    void Update()
    {

    }
}
