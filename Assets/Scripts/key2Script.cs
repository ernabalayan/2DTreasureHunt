using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key2Script : MonoBehaviour
{
    public GameObject sadNPC1;
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
        if (GameObject.Find("sadNPC1").GetComponent<sadNPC1Script>().gotDog == true)
        {
            hasKey = true;
            this.transform.parent = player.transform;
            this.transform.localPosition = new Vector2(2, -2);
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<PolygonCollider2D>().enabled = true;

        }
    }
}
