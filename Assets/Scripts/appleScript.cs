using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class appleScript : MonoBehaviour
{
    public GameObject player;
    public GameObject angryKid;
    public bool pressingE;
    public bool canGiveApple = false;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (pressingE)
        {
            if (GameObject.Find("angryKid").GetComponent<angryKidScript>().gotBurger == false)
            {
                this.transform.parent = player.transform;
                this.transform.localPosition = new Vector2(-2, -2);
                GameObject.Find("angryKid").GetComponent<angryKidScript>().gotApple = true;
            }

        }
        if (collision.gameObject.tag == "NPC1")
        {
            if (GameObject.Find("angryKid").GetComponent<angryKidScript>().rightItem == false && GameObject.Find("angryKid").GetComponent<angryKidScript>().gotApple == true)
                canGiveApple = true;

        }

    }    // Update is called once per frame

    private void Update()
        {
            if (Input.GetKey(KeyCode.E))
            {
                pressingE = true;
            }
        if (Input.GetKey(KeyCode.R))
        {
            GameObject.Find("angryKid").GetComponent<angryKidScript>().gotApple = false;
            this.transform.parent = null;
            pressingE = false;
            
        }

        if (canGiveApple)
        {
            this.transform.parent = angryKid.transform;
            this.transform.localPosition = new Vector2(3, 0);
        }
    }
  }

