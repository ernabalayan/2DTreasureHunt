using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eScript : MonoBehaviour
{
    public Sprite pressed;
    public GameObject R;
    public Sprite RnotPressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            GetComponent<SpriteRenderer>().sprite = pressed;
            R.GetComponent<SpriteRenderer>().sprite = RnotPressed;
        }
    }
}
