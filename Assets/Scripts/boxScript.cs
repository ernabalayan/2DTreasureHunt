using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boxScript : MonoBehaviour
{
    public bool pressingE;
    public SpriteRenderer E;
    public bool pressingR;
    public Sprite greenSprite;
    public GameObject player;
    static bool pickedUpBox;
    public bool wrongBox;
    public bool rightBox;

    // Start is called before the first frame update
    void Start()
    {
       
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (pressingE && pickedUpBox == false && GameObject.Find("cat").GetComponent<catScript>().pickedUpCat == false && GameObject.Find("puppy").GetComponent<dogScript>().pickedUpDog == false)
            {
                pickedUpBox = true;
                this.transform.parent = player.transform;
                this.transform.localPosition = new Vector2(0, -3);
            }
        }
       
        if(GameObject.Find("sadNPC4").GetComponent<sadNPC4Script>().firsttextPlayed == true && pressingE == true && collision.gameObject.tag == "Player" && gameObject.tag == "wrongBox")
        {
            GameObject.Find("sadNPC4").GetComponent<sadNPC4Script>().wrongPackage = true;
            Debug.Log("holding wrong box");
            wrongBox = true;
        }
     

        if (pressingE == true && collision.gameObject.tag == "Player" && gameObject.tag == "theBox")
        {
            GameObject.Find("sadNPC4").GetComponent<sadNPC4Script>().rightPackage = true;
            Debug.Log("holding right box");
            rightBox = true;
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
            pressingR = true;
            GameObject.Find("sadNPC4").GetComponent<sadNPC4Script>().rightPackage = false;
            GameObject.Find("sadNPC4").GetComponent<sadNPC4Script>().wrongPackage = false;
            wrongBox = false;
            rightBox = false;
            this.transform.parent = null;
            pressingE = false;
            pickedUpBox = false;
        }
       // if (pressingE)
       // {
        //    E.sprite = greenSprite;
      //  }

        }
   


}

