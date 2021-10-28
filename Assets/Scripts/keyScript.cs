using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyScript : MonoBehaviour
{
    public GameObject angryKid;
    public GameObject player;
    public bool hasKey;

    private void Start()
    {
        hasKey = false;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<PolygonCollider2D>().enabled = false;
    }
 
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("burger").GetComponent<burgerScript>().canGiveBurger == true || GameObject.Find("apple").GetComponent<appleScript>().canGiveApple == true)
        {
            hasKey = true;
            this.transform.parent = player.transform;
            this.transform.localPosition = new Vector2(2, -2);
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<PolygonCollider2D>().enabled = true;
          
        }
    }
}
