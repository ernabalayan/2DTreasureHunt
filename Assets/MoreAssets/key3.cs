using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key3 : MonoBehaviour
{
    public GameObject greedyNPC3;
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
        if (GameObject.Find("greedyNPC3").GetComponent<greedyNPCScript>().giveKey == true)
        {
            hasKey = true;
            this.transform.parent = player.transform;
            this.transform.localPosition = new Vector2(2, -2);
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<PolygonCollider2D>().enabled = true;

        }
    }
}
