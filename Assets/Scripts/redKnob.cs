using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redKnob : MonoBehaviour
{
    public GameObject player;
    public GameObject redDoor;
    public bool pressingE;
    public bool hasKnob;
 
    // Start is called before the first frame update
    void Start()
    {

        redDoor.GetComponent<BoxCollider2D>().enabled = true;
        redDoor.GetComponent<SpriteRenderer>().enabled = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (pressingE)
        {
            this.transform.parent = player.transform;
            this.transform.localPosition = new Vector2(-2, -2);
            hasKnob = true;

            if (collision.gameObject.tag == "redDoor")
            {
                redDoor.GetComponent<BoxCollider2D>().enabled = false;
                redDoor.GetComponent<SpriteRenderer>().enabled = false;
                Destroy(this.gameObject);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E)){
            pressingE = true;
        }
        if (Input.GetKey(KeyCode.R))
        {
            this.transform.parent = null;
        }
    }
}
