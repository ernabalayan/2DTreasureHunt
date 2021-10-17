using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameTextManagerScript : MonoBehaviour
{
    public Image textbox;
    public Text rulesText;
    public bool pressingSpace;

    public float timerLength = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        rulesText.GetComponent<Text>().enabled = false;
        textbox.GetComponent<Image>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            pressingSpace = true;
         
        }
        if (pressingSpace == true)
        {
            rulesText.GetComponent<Text>().enabled = true;
            textbox.GetComponent<Image>().enabled = true;
            timerLength -= Time.deltaTime;
        }
        if (timerLength <= 0f && pressingSpace == true)
        {
            rulesText.GetComponent<Text>().enabled = false;
            textbox.GetComponent<Image>().enabled = false;
            pressingSpace = false;
            timerLength = 3f;
            
        }
    }
}
