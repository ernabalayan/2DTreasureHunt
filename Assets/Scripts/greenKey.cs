using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenKey : MonoBehaviour
{
    public GameObject player;
    public GameObject greenDoor;
    public bool pressingE;
    public bool hasKey;
   
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
        greenDoor.GetComponent<BoxCollider2D>().enabled = true;
        greenDoor.GetComponent<SpriteRenderer>().enabled = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (pressingE)
        {
            this.transform.parent = player.transform;
            this.transform.localPosition = new Vector2(-2, -2);
            hasKey = true;
            

            if (collision.gameObject.tag == "greenDoor")
            {
                greenDoor.GetComponent<BoxCollider2D>().enabled = false;
                greenDoor.GetComponent<SpriteRenderer>().enabled = false;
                Destroy(this.gameObject);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(GameObject.Find("greedyNPC4").GetComponent<bossScript>().greenKeyActivated);

        if (GameObject.Find("greedyNPC4").GetComponent<bossScript>().greenKeyActivated)
        {
            GetComponent<BoxCollider2D>().enabled = true;
            GetComponent<SpriteRenderer>().enabled = true;

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
