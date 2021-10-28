using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogScript : MonoBehaviour
{
    public bool pressingE;
    public GameObject player;
    public bool pickedUpDog;
    public GameObject sadNPC1;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (pressingE && GameObject.Find("cat").GetComponent<catScript>().pickedUpCat == false)
            {
                pickedUpDog = true;
                this.transform.parent = player.transform;
                this.transform.localPosition = new Vector2(3, -2);
            }
        }
        if(collision.gameObject.tag == "sadNPC1")
        {
            this.transform.parent = sadNPC1.transform;
            this.transform.localPosition = new Vector2(0, 2);
            GetComponent<boxScript>().pressingE = false;
            pressingE = false;

        }
    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            pressingE = true;
        }
        if (Input.GetKey(KeyCode.R))
        {
            pressingE = false;
            this.transform.parent = null;
            pickedUpDog = false;
        }
        if(player.GetComponent<playerscript>().moveRight== true)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
