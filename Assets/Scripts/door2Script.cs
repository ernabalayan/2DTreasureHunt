using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door2Script : MonoBehaviour
{
    public GameObject key2;
    public SpriteRenderer spriteRenderer;
    public BoxCollider2D boxCollider;
    public SpriteRenderer keySpriteRenderer;
    public bool doorOpen;



    // Start is called before the first frame update
    void Start()
    {
        doorOpen = false;
        boxCollider.enabled = true;
        spriteRenderer.enabled = true;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (key2.GetComponent<key2Script>().hasKey)
        {
            doorOpen = true;
            boxCollider.enabled = false;
            spriteRenderer.enabled = false;
        }
        if (doorOpen)
        {
            Destroy(key2);

        }
    }
}
