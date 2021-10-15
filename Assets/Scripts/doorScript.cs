using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    public GameObject key;
    public Collider2D keyCollider;
    public SpriteRenderer spriteRenderer;
    public BoxCollider2D boxCollider;
    public SpriteRenderer keySpriteRenderer;
    public PolygonCollider2D keySpriteCollider;
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
        if (key.GetComponent<keyScript>().hasKey)
        {
            doorOpen = true;
            boxCollider.enabled = false;
            spriteRenderer.enabled = false;
        }
        if (doorOpen)
        {
            Destroy(key);

        }
    }
    // Update is called once per frame
  
}
