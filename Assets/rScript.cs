using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rScript : MonoBehaviour
{
    public Sprite pressed;
    public Sprite EnotPressed;
    public GameObject E;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            GetComponent<SpriteRenderer>().sprite = pressed;
            E.GetComponent<SpriteRenderer>().sprite = EnotPressed;
        }
    }
}
