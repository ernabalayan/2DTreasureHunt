using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class angryKidScript : MonoBehaviour
{

    public Text _text;
    public SpriteRenderer spriteRenderer;
    public bool gotBurger = false;
    public bool gotApple = false;
    public Sprite happyKid;
    public Collider2D angryKidCollider;
    public Collider2D playerCollider;
    // Start is called before the first frame update
    void Start()
    {
        _text.GetComponent<Text>().enabled = false;

    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!gotApple && !gotBurger)
        {
            _text.GetComponent<Text>().enabled = true;
            _text.text = "I'm so fucking hungry, find me some food and I will give you the key";
        }
        if (gotApple)
        {
            _text.GetComponent<Text>().enabled = true;
            _text.text = "ew I fucking hate fruit, get me something else or no key for you";
        }
      
        
        Debug.Log("colliding with NPC");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        _text.GetComponent<Text>().enabled = false;
        Debug.Log("not colliding with NPC");
    }
    private void Update()
    {
        if (playerCollider.IsTouching(angryKidCollider))
        {
            if (gotBurger)
            {
                _text.GetComponent<Text>().enabled = true;
                _text.text = "I hate tomatoes but I guess this will do, here's the key";
                spriteRenderer.sprite = happyKid;
            }
        }
     
    }

}

 


