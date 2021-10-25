using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blueKnobScript : MonoBehaviour
{
    public GameObject player;
    public GameObject blueDoor;
    public bool pressingE;
    public BoxCollider2D boxCollider;
    public SpriteRenderer spriteRenderer;
    public bool scoreActivated;
    public bool hasKey;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.enabled = false;
        boxCollider.enabled = false;
        blueDoor.GetComponent<BoxCollider2D>().enabled = true;
        blueDoor.GetComponent<SpriteRenderer>().enabled = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (spriteRenderer.enabled == true && boxCollider.enabled == true)
        {
            this.transform.parent = player.transform;
            this.transform.localPosition = new Vector2(-2, -2);
            hasKey = true;
            
        }
        if (collision.gameObject.tag == "blueDoor")
        {
            scoreActivated = true;
            blueDoor.GetComponent<BoxCollider2D>().enabled = false;
            blueDoor.GetComponent<SpriteRenderer>().enabled = false;
            spriteRenderer.enabled = false;
            boxCollider.enabled = false;

        }

    }
    // Update is called once per frame
    void Update()
    {
        if (scoreActivated)
        {
            Debug.Log("scoreActivated");
        }
        if (Input.GetKey(KeyCode.E))
        {
            pressingE = true;
        }
        if (Input.GetKey(KeyCode.R))
        {
            this.transform.parent = null;
        }
    }
}
