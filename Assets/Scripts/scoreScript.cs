using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    public Text _text;
    
    // Start is called before the first frame update
    void Start()
    {
        _text.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("blueKnob").GetComponent<blueKnobScript>().scoreActivated == true)
        {
            _text.enabled = true;
            _text.text = "$" + GameObject.Find("Player").GetComponent<playerscript>().score;
            

        }
        
    }
}
