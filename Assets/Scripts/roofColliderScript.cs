using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roofColliderScript : MonoBehaviour
{
    public GameObject door;
    public SpriteRenderer spriteRenderer;
  
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (door.GetComponent<doorScript>().doorOpen)
        {
            spriteRenderer.enabled = false;
        }
    }
}
