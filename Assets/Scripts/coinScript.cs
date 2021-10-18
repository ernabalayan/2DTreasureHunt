using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public SpriteRenderer spriteRenderer;
    public bool collidedWithPlayer;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider.enabled = false;
        spriteRenderer.enabled = false;
    }
    void Update()
    {
        if (GameObject.Find("buttonPressed").GetComponent<buttonScript>().buttonIsPressed == true && collidedWithPlayer == false )
        {
            boxCollider.enabled = true;
            spriteRenderer.enabled = true;
        }
        else
        {
            
            boxCollider.enabled = false;
            spriteRenderer.enabled = false;
        }
       if( GameObject.Find("buttonPressed").GetComponent<buttonScript>().buttonIsPressed == false)
        {
            collidedWithPlayer = false;
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collidedWithPlayer = true;
        }
        
         
        
    }
    // Update is called once per frame

}
