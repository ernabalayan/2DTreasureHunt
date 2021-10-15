using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    public bool pressingE;
    public GameObject player;
    static bool pickedUpBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (pressingE && pickedUpBox == false)
            {
                pickedUpBox = true;
                this.transform.parent = player.transform;
                this.transform.localPosition = new Vector2(0, -3);
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
            this.transform.parent = null;
            pressingE = false;
            pickedUpBox = false;
        }
    }
}
