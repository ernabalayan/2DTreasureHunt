using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnobScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = true;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GetComponent<SpriteRenderer>().enabled = true;
            Debug.Log("colliding with player");
        }
     }
      


  }

