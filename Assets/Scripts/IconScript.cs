using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconScript : MonoBehaviour
{
    public GameObject redKnobIcon;
    public GameObject blueKnobIcon;
    public GameObject greenKnobIcon;
    private GameObject RedKnob;
    private GameObject BlueKnob;
    private GameObject GreenKnob;
    public GameObject endScreen;

    // Start is called before the first frame update
    void Start()
    {
        RedKnob =  GameObject.Find("redKnob");
        BlueKnob = GameObject.Find("blueKnob");
        GreenKnob = GameObject.Find("greenKnob");
       
        
        redKnobIcon.GetComponent<SpriteRenderer>().enabled = false;
        blueKnobIcon.GetComponent<SpriteRenderer>().enabled = false;
        greenKnobIcon.GetComponent<SpriteRenderer>().enabled = false;
    }
 

    // Update is called once per frame
    void Update()
    {
        if(RedKnob.GetComponent<SpriteRenderer>().enabled == true)
        {
            redKnobIcon.GetComponent<SpriteRenderer>().enabled = true;
            //RedKnob.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (GreenKnob.GetComponent<SpriteRenderer>().enabled == true)
        {
            greenKnobIcon.GetComponent<SpriteRenderer>().enabled = true;
            //GreenKnob.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (BlueKnob.GetComponent<SpriteRenderer>().enabled == true)
        {
            blueKnobIcon.GetComponent<SpriteRenderer>().enabled = true;
            //BlueKnob.GetComponent<SpriteRenderer>().enabled = false;
        }

        if(greenKnobIcon.GetComponent<SpriteRenderer>().enabled == true && blueKnobIcon.GetComponent<SpriteRenderer>().enabled == true && redKnobIcon.GetComponent<SpriteRenderer>().enabled == true)
        {
            endScreen.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
