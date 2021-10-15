using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    public bool pressingE;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (pressingE)
        {
            this.transform.parent = player.transform;
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
        }
    }
}
