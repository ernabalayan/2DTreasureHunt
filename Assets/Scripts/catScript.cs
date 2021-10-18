using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catScript : MonoBehaviour
{
    public bool pressingE;
    public GameObject player;
    public bool pickedUpCat;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (pressingE && GameObject.Find("puppy").GetComponent<dogScript>().pickedUpDog == false)
            {
                pickedUpCat = true;
                this.transform.parent = player.transform;
                this.transform.localPosition = new Vector2(3, -2);
            }
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
            pickedUpCat = false;
        }
        if (player.GetComponent<playerscript>().moveRight == true)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
